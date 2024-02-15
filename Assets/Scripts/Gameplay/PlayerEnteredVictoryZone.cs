using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine.SceneManagement;
namespace Platformer.Gameplay
{
    
    /// <summary>
    /// This event is triggered when the player character enters a trigger with a VictoryZone component.
    /// </summary>
    /// <typeparam name="PlayerEnteredVictoryZone"></typeparam>
    public class PlayerEnteredVictoryZone : Simulation.Event<PlayerEnteredVictoryZone>
    {
        private int counter=0;
        public VictoryZone victoryZone;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            model.player.animator.SetTrigger("victory");
            model.player.controlEnabled = false;
            if (counter==0){
                SceneManager.LoadScene("level2");
                counter=1;
            }
            else if (counter==1){
                SceneManager.LoadScene("level3");
                counter=2;
            }
            else if (counter==2){
                SceneManager.LoadScene("level 1");
                counter=0;
            }
        }
    }
}