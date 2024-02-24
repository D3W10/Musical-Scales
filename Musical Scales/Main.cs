namespace Musical_Scales
{
    public partial class Main : Form
    {
        private readonly Note[] notes;

        public Main()
        {
            InitializeComponent();

            notes = new Note[] {
                new() { ABC = "C", Name = "Dó", Value = 1 },
                new() { ABC = "C♯", Name = "Dó♯", Value = 1.5m },
                new() { ABC = "D", Name = "Ré", Value = 2 },
                new() { ABC = "D♯", Name = "Ré♯", Value = 2.5m },
                new() { ABC = "E", Name = "Mi", Value = 3 },
                new() { ABC = "F", Name = "Fá", Value = 3.5m },
                new() { ABC = "F♯", Name = "Fá♯", Value = 4 },
                new() { ABC = "G", Name = "Sol", Value = 4.5m },
                new() { ABC = "G♯", Name = "Sol♯", Value = 5 },
                new() { ABC = "A", Name = "Lá", Value = 5.5m },
                new() { ABC = "A♯", Name = "Lá♯", Value = 6 },
                new() { ABC = "B", Name = "Si", Value = 6.5m }
            };

            FillScales();
        }

        private void FillScales()
        {
            foreach (Note note in notes)
            {
                if (!cbShowNames.Checked)
                {
                    cbbCurrentScale.Items.Add("Escala de " + note.ABC);
                    cbbWantedScale.Items.Add("Escala de " + note.ABC);
                }
                else
                {
                    cbbCurrentScale.Items.Add("Escala de " + note.Name);
                    cbbWantedScale.Items.Add("Escala de " + note.Name);
                }
            }
        }

        private void cbbCurrentScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCurrentScale.SelectedIndex != -1)
            {
                decimal val = notes[cbbCurrentScale.SelectedIndex].Value;

                for (int i = 0; i < 7; i++)
                {
                    if (!cbShowNames.Checked)
                        ((Label)Controls.Find("lblNoteC" + (i + 1), true)[0]).Text = Array.Find(notes, elm => elm.Value == val).ABC;
                    else
                        ((Label)Controls.Find("lblNoteC" + (i + 1), true)[0]).Text = Array.Find(notes, elm => elm.Value == val).Name;

                    val += (i == 2 || i == 6 ? 0.5m : 1);
                    if (val >= 7)
                        val -= 6;
                }
            }
        }

        private void cbbWantedScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWantedScale.SelectedIndex != -1)
            {
                decimal val = notes[cbbWantedScale.SelectedIndex].Value;

                for (int i = 0; i < 7; i++)
                {
                    if (!cbShowNames.Checked)
                        ((Label)Controls.Find("lblNoteW" + (i + 1), true)[0]).Text = Array.Find(notes, elm => elm.Value == val).ABC;
                    else
                        ((Label)Controls.Find("lblNoteW" + (i + 1), true)[0]).Text = Array.Find(notes, elm => elm.Value == val).Name;

                    val += (i == 2 || i == 6 ? 0.5m : 1);
                    if (val >= 7)
                        val -= 6;
                }
            }
        }

        private void cbShowNames_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cbbCurrentScale.Items.Count; i++)
            {
                string currentItem = cbbCurrentScale.Items[i].ToString();

                if (cbShowNames.Checked)
                    cbbCurrentScale.Items[i] = string.Concat(currentItem.AsSpan(0, currentItem.LastIndexOf(" ") + 1), Array.Find(notes, elm => elm.ABC == currentItem.Substring(currentItem.LastIndexOf(" ") + 1, currentItem.Length - currentItem.LastIndexOf(" ") - 1)).Name);
                else
                    cbbCurrentScale.Items[i] = string.Concat(currentItem.AsSpan(0, currentItem.LastIndexOf(" ") + 1), Array.Find(notes, elm => elm.Name == currentItem.Substring(currentItem.LastIndexOf(" ") + 1, currentItem.Length - currentItem.LastIndexOf(" ") - 1)).ABC);
            }

            for (int i = 0; i < cbbWantedScale.Items.Count; i++)
            {
                string currentItem = cbbWantedScale.Items[i].ToString();

                if (cbShowNames.Checked)
                    cbbWantedScale.Items[i] = string.Concat(currentItem.AsSpan(0, currentItem.LastIndexOf(" ") + 1), Array.Find(notes, elm => elm.ABC == currentItem.Substring(currentItem.LastIndexOf(" ") + 1, currentItem.Length - currentItem.LastIndexOf(" ") - 1)).Name);
                else
                    cbbWantedScale.Items[i] = string.Concat(currentItem.AsSpan(0, currentItem.LastIndexOf(" ") + 1), Array.Find(notes, elm => elm.Name == currentItem.Substring(currentItem.LastIndexOf(" ") + 1, currentItem.Length - currentItem.LastIndexOf(" ") - 1)).ABC);
            }
        }
    }
}