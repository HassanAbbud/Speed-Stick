public class DoubleJumpPowerUp : PowerUpBase
{
    public override void Activate(PlayerController player)
    {
        player.EnableDoubleJump(); // define this in PlayerController
    }
}
