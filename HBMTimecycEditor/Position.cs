using yt_DesignUI;

namespace HBMTimecycEditor
{
    enum Number
    {
        SPRITE_BRIGHT_VALUE = 24,
        DRAW_DIST_VALUE = 28,
        FOG_DIST_VALUE = 29,
        LIGHT_ON_GROUND = 30
    }

    class Position
    {
        public Position()
        {

        }
        public Position(Number number, ref EgoldsGoogleTextBox egtBox)
        {
            NumberPos = number;
            EGTBox = egtBox;
        }

        public int Index { get; set; }
        public int Length { get; set; }
        public int LineNum { get; set; }
        public Number NumberPos { get; set; }
        public EgoldsGoogleTextBox EGTBox { get; set; }
    }
}