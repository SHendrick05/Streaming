using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Streaming
{
    public static class Search
    {

        internal static List<Panel> LoadVidsIntoGUI(List<Video> vids)
        {
            List<Panel> results = new List<Panel>();
            int i = 0;
            foreach (Video vid in vids)
            {
                Panel template = Template.GetTemplate(i);
                template.Controls[1].Text = vid.Desc;
                template.Controls[0].Text = vid.Views.ToString() + " view(s)";
                template.Controls[2].Text = vid.Title;
                PictureBox box = (PictureBox)template.Controls[3];
                box.Image = vid.Thumbnail;
                vid.Pnl = template;
                results.Add(template);
                i++;
            }
            return results;
        }

        internal static List<Video> SearchVids(string param, List<Video> vids)
        {
            List<Video> result;
            List<string> searchParams = param.Split(' ').ToList();
            foreach (Video vid in vids)
            {
                vid.SScore = 0;
                foreach (string sP in searchParams)
                {
                    if (vid.Title.ToLower().Contains(sP.ToLower()))
                        vid.SScore += 2;
                    else if (vid.Desc.ToLower().Contains(sP.ToLower()))
                        vid.SScore++;
                }
            }
            result = vids.Where(i => i.SScore != 0).ToList();
            result = result.OrderByDescending(i => i.SScore).ToList();
            return result;
        }
    }



    public static class Template
    {
        internal static Panel GetTemplate(int i)
        {
            Panel tvideo0 = new Panel();
            Label tviewcount0 = new Label();
            TextBox tdesc0 = new TextBox();
            Label tvidtitle0 = new Label();
            PictureBox tthumbnail0 = new PictureBox();

            tvideo0.Controls.Add(tviewcount0);
            tvideo0.Controls.Add(tdesc0);
            tvideo0.Controls.Add(tvidtitle0);
            tvideo0.Controls.Add(tthumbnail0);
            tvideo0.Dock = System.Windows.Forms.DockStyle.Fill;
            tvideo0.Location = new System.Drawing.Point(3, 3);
            tvideo0.Name = "video" + i.ToString();
            tvideo0.Size = new System.Drawing.Size(434, 141);
            tvideo0.TabIndex = 1;
            tvideo0.Cursor = Cursors.Hand;
            tviewcount0.AutoSize = true;
            tviewcount0.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tviewcount0.ForeColor = System.Drawing.SystemColors.ControlLight;
            tviewcount0.Location = new System.Drawing.Point(249, 28);
            tviewcount0.Name = "viewcount" + i.ToString();
            tviewcount0.Size = new System.Drawing.Size(66, 21);
            tviewcount0.TabIndex = 3;
            tviewcount0.Text = "0 views";
            tviewcount0.Cursor = Cursors.Hand;
            tdesc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            tdesc0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tdesc0.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tdesc0.ForeColor = System.Drawing.SystemColors.ControlDark;
            tdesc0.Location = new System.Drawing.Point(246, 53);
            tdesc0.Multiline = true;
            tdesc0.Name = "desc" + i.ToString();
            tdesc0.Size = new System.Drawing.Size(568, 88);
            tdesc0.TabIndex = 2;
            tdesc0.Text = "Sample description...";
            tdesc0.ReadOnly = true;
            tdesc0.Cursor = Cursors.Hand;
            tvidtitle0.AutoSize = true;
            tvidtitle0.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tvidtitle0.ForeColor = System.Drawing.SystemColors.Control;
            tvidtitle0.Location = new System.Drawing.Point(249, 3);
            tvidtitle0.Name = "vidtitle" + i.ToString();
            tvidtitle0.Size = new System.Drawing.Size(109, 22);
            tvidtitle0.TabIndex = 1;
            tvidtitle0.Text = "Testing title";
            tvidtitle0.Cursor = Cursors.Hand;
            tthumbnail0.Dock = System.Windows.Forms.DockStyle.Left;
            tthumbnail0.Location = new System.Drawing.Point(0, 0);
            tthumbnail0.Name = "thumbnail" + i.ToString();
            tthumbnail0.Size = new System.Drawing.Size(240, 141);
            tthumbnail0.TabIndex = 0;
            tthumbnail0.TabStop = false;
            tthumbnail0.Cursor = Cursors.Hand;

            return tvideo0;
        }
    }
}
