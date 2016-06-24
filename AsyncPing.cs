using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Launcher
{
    public class AsyncPing
    {
        private Form1 form;

        //Pings every 20 seconds
        private int updateTime = 2; 

        public AsyncPing(Form1 form)
        {
            this.form = form;
        }

        public async Task startUpdateStatus()
        {
            while (true)
            {
                Task<int> longRunningTask = LongRunningOperationAsync();
                int result = await longRunningTask;
            }
        }

        private async Task<int> LongRunningOperationAsync()
        {
            await Task.Delay(updateTime * 1000);
            Console.WriteLine("UPDATING");

            List<Server> servers = form.serverContainer.getServers();
            List<Server> iterateServers = new List<Server>(servers);

            if (iterateServers.Count < 0) return -1;

            Console.WriteLine("UPDATING STATUS");

            for (int i = 0; i < iterateServers.Count; i++)
            {
                Server server = iterateServers[i];

                PingReply reply;
                bool status = false;

                using (Ping ping = new Ping())
                {
                    try
                    {
                        reply = ping.Send(URLFormatter.formatPingUrl(server.realmlist), 300);
                        status = reply.Status == IPStatus.Success;
                    }
                    catch (Exception e) { }
                }

                Console.WriteLine("UPDATED TEXT FIELD");

                var task = Task.Run(() => { form.serverContainer.updateStatus(server, status ? "Online" : "Offline"); });
                await task;
                task = Task.Run(() => { form.updateStatusColors(); });
                await task;
            }

            return -1;
        }
    }
}
