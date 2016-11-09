using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Trestto.Dashboard.App.Controllers
{
    public class DashController : Controller
    {
        [HttpGet]
        public JsonResult AtualizaPainelHoraHora()
        {

            List<Objetos.AtualizaPainelHoraHoraTotal> total = new List<Objetos.AtualizaPainelHoraHoraTotal>();

            total = AtualizaPainelHoraHoraTotal();

            List<Objetos.AtualizaPainelHoraHora> Dados = new List<Objetos.AtualizaPainelHoraHora>();


            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_Painel_V3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelHoraHora
                {
                    Status = item["Status"].ToString(),
                    status9 = Convert.ToInt32(item["9"]),
                    status8 = Convert.ToInt32(item["8"]),
                    status10 = Convert.ToInt32(item["10"]),
                    status11 = Convert.ToInt32(item["11"]),
                    status12 = Convert.ToInt32(item["12"]),
                    status13 = Convert.ToInt32(item["13"]),
                    status14 = Convert.ToInt32(item["14"]),
                    status15 = Convert.ToInt32(item["15"]),
                    status16 = Convert.ToInt32(item["16"]),
                    status17 = Convert.ToInt32(item["17"]),
                    status18 = Convert.ToInt32(item["18"]),
                    status19 = Convert.ToInt32(item["19"]),
                    status20 = Convert.ToInt32(item["20"]),
                    status21 = Convert.ToInt32(item["21"]),
                    Total = total[i].Total
                });
                i++;
            }

            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public List<Objetos.AtualizaPainelHoraHoraTotal> AtualizaPainelHoraHoraTotal()
        {
            List<Objetos.AtualizaPainelHoraHoraTotal> Dados = new List<Objetos.AtualizaPainelHoraHoraTotal>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_PainelTotal_V2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();



            dt.Load(dr);


            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelHoraHoraTotal
                {
                    Total = item["Total"].ToString()
                });
            }

            sqlConnection1.Close();

            return Dados;



        }

        [HttpGet]
        public JsonResult AtualizaPainelHoraHoraPercentual()
        {
            List<Objetos.AtualizaPainelHoraHoraTotal> total = new List<Objetos.AtualizaPainelHoraHoraTotal>();

            total = AtualizaPainelHoraHoraPercentualTotal();

            List<Objetos.AtualizaPainelHoraHora> Dados = new List<Objetos.AtualizaPainelHoraHora>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_PainelPercentual_V3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelHoraHora
                {
                    Status = item["Status"].ToString(),
                    status8 = Convert.ToDouble(item["8"]),
                    status9 = Convert.ToDouble(item["9"]),
                    status10 = Convert.ToDouble(item["10"]),
                    status11 = Convert.ToDouble(item["11"]),
                    status12 = Convert.ToDouble(item["12"]),
                    status13 = Convert.ToDouble(item["13"]),
                    status14 = Convert.ToDouble(item["14"]),
                    status15 = Convert.ToDouble(item["15"]),
                    status16 = Convert.ToDouble(item["16"]),
                    status17 = Convert.ToDouble(item["17"]),
                    status18 = Convert.ToDouble(item["18"]),
                    status19 = Convert.ToDouble(item["19"]),
                    status20 = Convert.ToDouble(item["20"]),
                    status21 = Convert.ToDouble(item["21"]),
                    Total = total[i].Total

                });
                i++;
            }


            //exibe os dados no GridView
            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public List<Objetos.AtualizaPainelHoraHoraTotal> AtualizaPainelHoraHoraPercentualTotal()
        {
            List<Objetos.AtualizaPainelHoraHoraTotal> Dados = new List<Objetos.AtualizaPainelHoraHoraTotal>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_PainelTotalPercentual_V3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelHoraHoraTotal
                {
                    Total = item["Total"].ToString()
                });
            }


            sqlConnection1.Close();

            return Dados;
        }

        [HttpGet]
        public JsonResult AtualizaPainelTelefonia()
        {
            var text = "";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://162.255.139.226/ucenter/api/report/ObterStatusTelefonia/trestto/beleza2016/179/2016-10-26/2016-10-27%2018:00:00");
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";

            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            var des = (List<Objetos.AtualizaPainelTelefonia>)Newtonsoft.Json.JsonConvert.DeserializeObject(text, typeof(List<Objetos.AtualizaPainelTelefonia>));

            Decimal valortotal = 0;

            foreach (var item in des)
            {
                valortotal += Convert.ToInt32(item.Valor);
            }

            foreach (var item in des)
            {
                item.Representatividade = String.Format("{0:0.00}", ((Convert.ToInt32(item.Valor) / valortotal) * 100));
            }


            return Json(des, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AtualizaGraficoTelefonia()
        {
            List<Objetos.AtualizaGraficoTelefonia> Dados = new List<Objetos.AtualizaGraficoTelefonia>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_StatusTelefoniaTotalPercentual_V1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaGraficoTelefonia
                {
                    Dado = item["Dado"].ToString(),
                    Valor = Convert.ToDouble(item["Valor"])
                });
            }

            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AtualizaProdutividadeAgentes()
        {


            List<Objetos.AtualizaProdutividadeAgentes> Dados = new List<Objetos.AtualizaProdutividadeAgentes>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_ProdutividadeAgentes_V2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaProdutividadeAgentes
                {
                    Coluna11 = item[10].ToString(),
                    Coluna12 = item[11].ToString(),
                    Coluna13 = item[12].ToString(),
                    Coluna14 = item[13].ToString(),
                    AlegaPagamento = item["AlegaPagamento"].ToString(),
                    Atendidas = item["Atendidas"].ToString(),
                    TMA = item["TMA"].ToString(),
                    CPC = item["CPC"].ToString(),
                    Nome = item["Nome"].ToString(),
                    Promessa = item["Promessa"].ToString(),
                    Status = item["Status"].ToString(),
                    TempoDisponivel = item["TempoDisponivel"].ToString(),
                    TempoLogado = item["TempoLogado"].ToString(),
                    TME = item["TME"].ToString()
                });
            }
            sqlConnection1.Close();
            return Json(Dados, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult AtualizaMonitoramentoCanais()
        {

            var text = "";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://162.255.139.226/ucenter/api/report/ObterOcupacao/trestto/beleza2016/179/2016-11-08%2005:49:29/2016-11-09%2008:05:12/");
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";

            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            var des = (List<Objetos.AtualizaMonitoramentoCanais>)Newtonsoft.Json.JsonConvert.DeserializeObject(text, typeof(List<Objetos.AtualizaMonitoramentoCanais>));


            decimal agentestotal = 0;

            decimal.TryParse(des[0].AgentesTotal, out agentestotal);

            decimal canaltotal = 0;

            decimal.TryParse(des[0].CanaisTotal, out canaltotal);

            if (agentestotal > 0)
            {
                des[0].AgentesOcupadosPercentual = String.Format("{0:0.00}", ((Convert.ToDecimal(des[0].AgentesOcupados) / Convert.ToDecimal(des[0].AgentesTotal)) * 100));
            }
            else
            {
                des[0].AgentesOcupadosPercentual = "0,00";

            }

            if (canaltotal > 0)
            {
                des[0].CanaisOcupadosPercentual = String.Format("{0:0.00}", ((Convert.ToDecimal(des[0].CanaisOcupados) / Convert.ToDecimal(des[0].CanaisTotal)) * 100));
            }
            else
            {
                des[0].CanaisOcupadosPercentual = "0,00";
            }





            //List<Objetos.AtualizaMonitoramentoCanais> Dados = new List<Objetos.AtualizaMonitoramentoCanais>();

            //SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            //SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_MonitoramentoCanais_V1";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);

            //foreach (DataRow item in dt.Rows)
            //{
            //    Dados.Add(new Objetos.AtualizaMonitoramentoCanais
            //    {
            //        AgentesOcupados = item["AgentesOcupados"].ToString(),
            //        AgentesOcupadosPercentual = Convert.ToDouble(item["AgentesOcupadosPercentual"]),
            //        AgentesTotal = item["AgentesTotal"].ToString(),
            //        CanaisOcupados = item["CanaisOcupados"].ToString(),
            //        CanaisOcupadosPercentual = Convert.ToDouble(item["CanaisOcupadosPercentual"]),
            //        CanaisTotal = item["CanaisTotal"].ToString()
            //    });
            //}
            //sqlConnection1.Close();
            return Json(des, JsonRequestBehavior.AllowGet);

            // MAIOR IGUAL QUE 60 - VERDE
            //if (Convert.ToDecimal(CanaisOcupadosPercentual) >= 60)
            //{
            //    pnCanaisOcupadosPercentual.BackColor = System.Drawing.ColorTranslator.FromHtml("#84F075");
            //}
            //// MENOR QUE 60 E MAIOR QUE 30 - AMARELO
            //else if (Convert.ToDecimal(CanaisOcupadosPercentual) < 60 && Convert.ToDecimal(CanaisOcupadosPercentual) > 30)
            //{
            //    pnCanaisOcupadosPercentual.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF075");
            //}
            //// MENOR 30 - VERMELHO
            //else
            //{
            //    pnCanaisOcupadosPercentual.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07575");
            //}



            // COLORE AGENTES

            // MAIOR IGUAL QUE 60 - VERDE
            //if (Convert.ToDecimal(AgentesOcupadosPercentual) >= 60)
            //{
            //    pnAgentesOcupadosPercentual.BackColor = System.Drawing.ColorTranslator.FromHtml("#84F075");
            //}
            //// MENOR QUE 60 E MAIOR QUE 30 - AMARELO
            //else if (Convert.ToDecimal(AgentesOcupadosPercentual) < 60 && Convert.ToDecimal(AgentesOcupadosPercentual) > 30)
            //{
            //    pnAgentesOcupadosPercentual.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF075");
            //}
            //// MENOR 30 - VERMELHO
            //else
            //{
            //    pnAgentesOcupadosPercentual.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07575");
            //}

        }

        [HttpGet]
        public JsonResult AtualizaVelocimetros()

        {
            List<Objetos.AtualizaVelocimentros> Dados = new List<Objetos.AtualizaVelocimentros>();
            DataTable dt = new DataTable();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_VelocimetrosOcupacao_V1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);


            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaVelocimentros
                {
                    Dado = item["Dado"].ToString(),
                    Valor = item["Valor"].ToString()
                });
            }
            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AtualizaControleMailing()
        {

            var text = "";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://162.255.139.226/ucenter/api/report/ObterMailing/trestto/beleza2016/179/2016-10-26/2016-10-27%2018:00:00");
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";

            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }



            var x = Json(text);


            List<Objetos.AtualizaControleMailing> des = (List<Objetos.AtualizaControleMailing>)Newtonsoft.Json.JsonConvert.DeserializeObject(text, typeof(List<Objetos.AtualizaControleMailing>));


            List<Objetos.AtualizaControleMailing> Dados = new List<Objetos.AtualizaControleMailing>();


            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_ControleMailing_V1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaControleMailing
                {
                    MailingRecebido = item[0].ToString(),
                    MailingImportado = item[1].ToString(),
                    MailingTrabalhado = item[2].ToString(),
                    Spins = item[3].ToString(),
                    Atendidas = item[4].ToString(),
                    CPC = item[5].ToString(),
                    Promessa = item[6].ToString(),
                    AlegaPagamento = item[7].ToString(),
                    CPCPercent = item[8].ToString(),
                    PromessaPercent = item[9].ToString(),
                    AlegaPagamentoPercent = item[10].ToString(),
                    LocalizacaoPercent = item[11].ToString(),
                    MailingTrabalhadoPercent = item[12].ToString()
                });
            }


            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult AtualizaControleMailingGrafico()
        {




            List<Objetos.AtualizaControleMailing> Dados = new List<Objetos.AtualizaControleMailing>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_ControleMailing_V1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaControleMailing
                {
                    MailingRecebido = item[0].ToString(),
                    MailingImportado = item[1].ToString(),
                    MailingTrabalhado = item[2].ToString(),
                    Spins = item[3].ToString(),
                    Atendidas = item[4].ToString(),
                    CPC = item[5].ToString(),
                    Promessa = item[6].ToString(),
                    AlegaPagamento = item[7].ToString(),
                    CPCPercent = item[8].ToString(),
                    PromessaPercent = item[9].ToString(),
                    AlegaPagamentoPercent = item[10].ToString(),
                    LocalizacaoPercent = item[11].ToString(),
                    MailingTrabalhadoPercent = item[12].ToString()
                });
            }
            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AtualizaConversaoCPC()
        {

            List<Objetos.AtualizaConversaoCPC> Dados = new List<Objetos.AtualizaConversaoCPC>();
            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_Painel_ConversaoCPC_V2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaConversaoCPC
                {
                    Qnt = item["Qnt"].ToString(),
                    Representatividade = item["Representatividade"].ToString(),
                    Status = item["Status"].ToString()
                });
            }

            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

    }
}