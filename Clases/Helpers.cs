using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class Helpers
    {
        //propiedades para los botones de las alertas
        string titulo_alert;
        MessageBoxButtons botones;
        MessageBoxIcon iconos;

        public void Advertencia(string smg)
        {
            titulo_alert = "Advertencia";
            botones = MessageBoxButtons.OK;
            iconos = MessageBoxIcon.Warning;

            MessageBox.Show(smg, titulo_alert ,botones, iconos);
        }
        public bool Confirmar(string smg)
        {
            bool result = false;
            MessageBoxButtons option = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            if (MessageBox.Show(smg,"Confirmar",option,icon)== DialogResult.Yes)
            {
                result = true;
            }
            return result;
        }

        public bool Question(string smg)
        {
            bool resp = false;
            botones = MessageBoxButtons.YesNo;
            iconos = MessageBoxIcon.Question;

            if (MessageBox.Show(smg, "Confirmar", botones, iconos) == DialogResult.Yes)
            {
                resp = true;
            }
            return resp;
        }
        public bool Exito(string smg)
        {
            bool resp = false;
            botones = MessageBoxButtons.OK;
            iconos = MessageBoxIcon.Information;

            if (MessageBox.Show(smg, "Exitoso",botones,iconos)== DialogResult.OK)
            {
                resp=true;
            }
            return resp;
        }
    }
}
