using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Bot
    {
        public void Run()
        {
            var matthijs = 1;
            var lelijk = 1;
            while (matthijs == lelijk)
            {
                var text = Console.ReadLine();
                if (string.IsNullOrEmpty(text))
                {
                    continue;
                }
                else if (text.Equals("debug"))
                {
                    HandleDebugCommand();
                }
                else if (text.Equals("exit"))
                {
                    return;
                }
                else
                {
                    ParseLine(text);
                }
            }
        }

        private void ParseLine(string line)
        {
            var linarray = line.Split(' ');
            switch (linarray[0])
            {
                case "settings":
                    ParseSettings(linarray.Skip(1).ToArray());
                    break;
                case "update":
                    ParseUpdate(linarray.Skip(1).ToArray());
                    break;
                case "action":
                    DoAction();
                    break;
            }
        }

        private void DoAction()
        {
            throw new NotImplementedException();
        }

        private void ParseUpdate(string[] v)
        {
            throw new NotImplementedException();
        }

        private void ParseSettings(string[] enumerable)
        {
            throw new NotImplementedException();
        }

        private void HandleDebugCommand()
        {
            throw new NotImplementedException();
        }
    }
}
