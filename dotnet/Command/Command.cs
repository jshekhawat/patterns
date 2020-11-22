using System;


namespace dotnet {

    public class Invoker {

    }

    public class Reciever {

        
    }

    public interface ICommand {
        public void Execute();
    }


    public class Command1 : ICommand
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class Command2 : ICommand
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    

}
