﻿namespace Command.Base;
internal class SimpleRemoteControl
{
    private ICommand _slot;

    //public SimpleRemoteControl() { }

    public void SetCommand(ICommand command)
    {
        _slot = command;
    }

    public void ButtonWasPressed()
    {
        _slot.Execute();
    }
}
