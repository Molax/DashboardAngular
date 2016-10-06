using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Trestto.Dashboard.App.Controllers
{
    public class DashController : Controller
    {
        [HttpGet]
        public JsonResult AtualizaPainelHoraHora()
        {
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

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelHoraHora
                {
                    Status = item["Status"].ToString(),
                    status8 = item["8"].ToString(),
                    status9 = item["9"].ToString(),
                    status10 = item["10"].ToString(),
                    status11 = item["11"].ToString(),
                    status12 = item["12"].ToString(),
                    status13 = item["13"].ToString(),
                    status14 = item["14"].ToString(),
                    status15 = item["15"].ToString(),
                    status16 = item["16"].ToString(),
                    status17 = item["17"].ToString(),
                    status18 = item["18"].ToString(),
                    status19 = item["19"].ToString(),
                    status20 = item["20"].ToString(),
                    status21 = item["21"].ToString(),

                });
            }

            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult AtualizaPainelHoraHoraTotal()
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
                    Total = Convert.ToInt32(item["Total"])
                });
            }

            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);



        }

        [HttpGet]
        public JsonResult AtualizaPainelHoraHoraPercentual()
        {

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

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelHoraHora
                {
                    Status = item["Status"].ToString(),
                    status8 = item["8"].ToString(),
                    status9 = item["9"].ToString(),
                    status10 = item["10"].ToString(),
                    status11 = item["11"].ToString(),
                    status12 = item["12"].ToString(),
                    status13 = item["13"].ToString(),
                    status14 = item["14"].ToString(),
                    status15 = item["15"].ToString(),
                    status16 = item["16"].ToString(),
                    status17 = item["17"].ToString(),
                    status18 = item["18"].ToString(),
                    status19 = item["19"].ToString(),
                    status20 = item["20"].ToString(),
                    status21 = item["21"].ToString(),

                });
            }


            //exibe os dados no GridView
            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AtualizaPainelHoraHoraPercentualTotal()
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
                    Total = Convert.ToInt32(item["Total"])
                });
            }


            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AtualizaPainelTelefonia()
        {
            List<Objetos.AtualizaPainelTelefonia> Dados = new List<Objetos.AtualizaPainelTelefonia>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_StatusTelefonia_V2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaPainelTelefonia
                {
                    Dado = item["Dado"].ToString(),
                    Representatividade = item["Representatividade"].ToString(),
                    Valor = item["Valor"].ToString()
                });
            }

            sqlConnection1.Close();

            return Json(Dados, JsonRequestBehavior.AllowGet);
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
                    Valor = item["Valor"].ToString()
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

            List<Objetos.AtualizaMonitoramentoCanais> Dados = new List<Objetos.AtualizaMonitoramentoCanais>();

            SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DASHBOARD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_RPT_OPTIMUS_Dashboard_362_MonitoramentoCanais_V1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Dados.Add(new Objetos.AtualizaMonitoramentoCanais
                {
                    AgentesOcupados = item["AgentesOcupados"].ToString(),
                    AgentesOcupadosPercentual = item["AgentesOcupadosPercentual"].ToString(),
                    AgentesTotal = item["AgentesTotal"].ToString(),
                    CanaisOcupados = item["CanaisOcupados"].ToString(),
                    CanaisOcupadosPercentual = item["CanaisOcupadosPercentual"].ToString(),
                    CanaisTotal = item["CanaisTotal"].ToString()
                });
            }
            sqlConnection1.Close();
            return Json(Dados, JsonRequestBehavior.AllowGet);

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
            List<Objetos.AtualizaGraficoTelefonia> Dados = new List<Objetos.AtualizaGraficoTelefonia>();
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
                Dados.Add(new Objetos.AtualizaGraficoTelefonia
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