using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business;
using domain;

namespace myMusicLibrary
{
    public partial class MusicLibrary : Form
    {
        public MusicLibrary()
        {
            InitializeComponent();
        }

        private void MusicLibrary_Load(object sender, EventArgs e)
        {
            DiscoService service = new DiscoService();
            dgvDiscos.DataSource = service.discoList();
            showTotalAlbums();

        }

        private void showTotalAlbums()
        {
            int numberAlbums = dgvDiscos.Rows.Count;
            lblTotalAlbums.Text = "Total Albums: " + numberAlbums;

        }
    }
}
