using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HeroSystemEngine.Manuevers;
using HeroSystemsEngine.CombatSequence;

namespace HeroSystemsEngineUI
{
    /// <summary>
    /// Interaction logic for CombatSequenceWidget.xaml
    /// </summary>

    public partial class CombatSequenceWidget : Page
    {
        CombatSequence Sequence;
      //  public CombatSequence Sequence;
        public CombatSequenceWidget()
        {
            InitializeComponent();
            CharacterTestObjectFactory Factory=  new CharacterTestObjectFactory();

            CombatSequence sequence = new CombatSequence();
            sequence.AddCharacter(Factory.BaseCharacter);
            sequence.AddCharacter(Factory.BaseCharacter);
            sequence.AddCharacter(Factory.BaseCharacter);
            CombatSequenceTreeView.ItemsSource = sequence.SegmentList;
            sequence.StartCombat();
            Sequence = sequence;
           // Phase.PhaseStartHandler += RenderSelectedPhase;


        }


        private void CompletePhaseButton_Click(object sender, RoutedEventArgs e)
        {
            Sequence.ActivePhase.Complete();
        }




        
    }

}
