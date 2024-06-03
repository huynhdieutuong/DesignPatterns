using Command.Base;

namespace Command.Stereo;
internal class StereoOnWithCDCommand : ICommand
{
    private readonly Stereo _stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.On();
        _stereo.SetCd();
        _stereo.SetVolume(11);
    }

    public void Undo()
    {
        _stereo.Off();
    }
}
