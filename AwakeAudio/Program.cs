using System.Media;

var player = new SoundPlayer();
player.SoundLocation = @"F:\Libraries\Music\speaker anti-sleep beep\test.wav";

for (int i = 0; i < 20; i++)
{
    player.Play();
    Thread.Sleep(1000);
}
