using System;
using BoletoNet.Enums;
using System.Collections.Generic;
using BoletoNet.Excecoes;

namespace BoletoNet
{
    public enum EnumCodigoMovimento_Sicoob
    {
        EntradaConfirmada = 02,                                       //02 Entrada confirmada
        EntradaRejeitada = 03,                                        //03 Entrada rejeitada
        TransferenciaDeCarteiraEntrada = 04,                          //04 Transferência de Carteira/Entrada
        TransferenciaDeCarteiraBaixa = 05,                            //05 Transferência de Carteira/Baixa
        LiquidacaoNormal = 06,                                        //06 Liquidação normal
        Baixado = 09,                                                 //09 Baixado
        BaixadoConformeInstrucoesDaCooperativaDeCredito = 10,         //10 Baixado conforme instruções da cooperativa de crédito
        TituloEmSer = 11,                                             //11 Títulso em Ser
        AbatimentoConcedido = 12,                                     //12 Abatimento concedido
        AbatimentoCancelado = 13,                                     //13 Abatimento cancelado
        VencimentoAlterado = 14,                                      //14 Vencimento alterado
        LiquidacaoEmCartorio = 15,                                    //15 Liquidação em cartório
        LiquidacaoAposBaixa = 17,                                     //17 Liquidação após baixa
        ConfirmacaoDeRecebimentoDeInstrucaoDeProtesto = 19,           //19 Confirmação de recebimento de instrução de protesto
        ConfirmacaoDeRecebimentoDeInstrucaoDeSustacaoDeProtesto = 20, //20 Confirmação de recebimento de instrução de sustação de protesto
        EntradaDeTituloEmCartorio = 23,                               //23 Entrada de título em cartório
        EntradaRejeitadaPorCEPIrregular = 24,                         //24 Entrada rejeitada por CEP irregular
        InstrucaoRejeitada = 26,                                      //26 Instrução rejeitada
        BaixaRejeitada = 27,                                          //27 Baixa rejeitada        
        Tarifa = 28,                                                  //28 Tarifa
        RejeicaoDoPagador = 29,                                       //29 Rejeição do pagador
        AlteracaoRejeitada = 30,                                      //30 Alteração rejeitada        
        ConfirmacaoDePedidoDeAlteracaoDeOutrosDados = 33,             //33 Confirmação de pedido de alteração de outros dados
        RetiradoDeCartorioEManutencaoEmCarteira = 34,                 //34 Retirado de cartório e manutenção em carteira
        AceiteDoPagador = 35,                                         //35 Aceite do pagador
        TransferenciaModadalidadeCobranca = 48,                       //48 Confirmação de instrução de transferência de carteira/modalidade de cobrança
        ConfirmacaoInstrucaoDesconto = 07,                            //07 Confirmação do Recebimento da Instrução de Desconto
        ConfirmacaoRecebimentoCancelamentoDesconto = 08,              //08 Confirmação do Recebimento do Cancelamento do Desconto
        ProtestadoEBaixado = 25,                                      //25 Protestado e Baixado (Baixa por Ter Sido Protestado)
        ConfirmacaoEnvioSMS = 36,                                     //36 Confirmação de envio de e-mail/SMS
        EnvioSMSRejeitado = 37,                                       //37 Envio de e-mail/SMS rejeitado
        ConfirmacaoAlteracaoPrazoRececimento = 38,                    //38 Confirmação de alteração do Prazo Limite de Recebimento (a data deve ser
        ConfirmacaoDispensaPrazoLimiteRecebimento = 39,               //39 Confirmação de Dispensa de Prazo Limite de Recebimento
        ConfirmacaoAlteracaoNumeroTitulo = 40,                        //40 Confirmação da alteração do número do título dado pelo Beneficiário
        ConfirmacaoAteracaoNumeroParticipante = 41,                   //41 Confirmação da alteração do número controle do Participante
        ConfirmacaoAlteracaoDadosPagador = 42,                        //42 Confirmação da alteração dos dados do Pagador
        ConfirmacaoAlteracaoDadosPagadorAvalista = 43,                //43 Confirmação da alteração dos dados do Pagadorr/Avalista
        TituloPagoComChequeDevolvido = 44,                            //44 Título pago com cheque devolvido
        TituloPagoComChequeCompensado = 45,                           //45 Título pago com cheque compensado
        InstrucaoParacancelarProtestoConfirmada = 46,                  //46 Instrução para cancelar protesto confirmada
        InstrucaoParaProtestoParaFinsFalimentaresConfirmada = 47,     //47 Instrução para protesto para fins falimentares confirmada
        AlteracaoContratoCobranca = 49,                               //49 Alteração de contrato de cobrança
        TituloPagoComChequePendenteLiquidacao = 50,                   //50 Título pago com cheque pendente de liquidação
        TituloDDAReconhecidoPeloPagador = 51,                         //51 Título DDA reconhecido pelo Pagador
        TituloDDANaoReconhecidoPeloPagador = 52,                      //52 Título DDA não reconhecido pelo Pagador
        TituloDDARecusadoCIP = 53,                                    //53 Título DDA recusado pela CIP
        ConfirmacaoBaixaTituloNegativoSemProtesto = 54,               //54 Confirmação da Instrução de Baixa de Título Negativado sem Protesto
        ConfirmacaoPedidoDispensaMulta = 55,                          //55 Confirmação de Pedido de Dispensa de Multa
        ConfirmacaoPedidoCobrancaMulta = 56,                          //56 Confirmação do Pedido de Cobrança de Multa
        ConfirmacaoPedidoAlteracaoCobrancaJuros = 57,                 //57 Confirmação do Pedido de Alteração de Cobrança de Juros
        ConfirmacaoPedidoAlteracaoValorDataDesconto = 58,             //58 Confirmação do Pedido de Alteração do Valor/Data de Desconto
        ConfirmacaoPedidoAlteracaoBeneficiario = 59,                  //59 Confirmação do Pedido de Alteração do Beneficiário do Título
        ConfirmacaoPedidoDispensaJurosMora = 60,                      //60 Confirmação do Pedido de Dispensa de Juros de Mora
        ConfirmacaoDesistenciaProtesto = 85,                          //85 Confirmação de Desistência de Protesto
        ConfirmacaoCancelamentoProtesto = 86                          //86 Confirmação de cancelamento do Protesto"
    }

    public class CodigoMovimento_Sicoob : AbstractCodigoMovimento, ICodigoMovimento
    {
        #region Construtores
        internal CodigoMovimento_Sicoob()
        {
        }

        public CodigoMovimento_Sicoob(int codigo)
        {
            try
            {
                carregar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }
        #endregion

        private void carregar(int codigo)
        {
            try
            {
                this.Banco = new Banco_Sicoob();

                var movimento = (EnumCodigoMovimento_Sicoob)codigo;
                Codigo = codigo;
                Descricao = descricoes[movimento];
            }
            catch (Exception ex)
            {
                throw new BoletoNetException("Código de movimento é inválido", ex);
            }
        }

        public override TipoOcorrenciaRetorno ObterCorrespondenteFebraban()
        {
            return ObterCorrespondenteFebraban(correspondentesFebraban, (EnumCodigoMovimento_Sicoob)Codigo);
        }

        #region Dicionários
        private Dictionary<EnumCodigoMovimento_Sicoob, TipoOcorrenciaRetorno> correspondentesFebraban = new Dictionary<EnumCodigoMovimento_Sicoob, TipoOcorrenciaRetorno>()
        {
            { EnumCodigoMovimento_Sicoob.EntradaConfirmada                                      ,TipoOcorrenciaRetorno.EntradaConfirmada },
            { EnumCodigoMovimento_Sicoob.EntradaRejeitada                                       ,TipoOcorrenciaRetorno.EntradaRejeitada },
            { EnumCodigoMovimento_Sicoob.TransferenciaDeCarteiraEntrada                         ,TipoOcorrenciaRetorno.TransferenciaDeCarteiraEntrada  },
            { EnumCodigoMovimento_Sicoob.TransferenciaDeCarteiraBaixa                           ,TipoOcorrenciaRetorno.TransferenciaDeCarteiraBaixa  },
            { EnumCodigoMovimento_Sicoob.LiquidacaoNormal                                       ,TipoOcorrenciaRetorno.Liquidacao },
            { EnumCodigoMovimento_Sicoob.Baixado                                                ,TipoOcorrenciaRetorno.Baixa },
            { EnumCodigoMovimento_Sicoob.BaixadoConformeInstrucoesDaCooperativaDeCredito        ,TipoOcorrenciaRetorno.Baixa },
            { EnumCodigoMovimento_Sicoob.AbatimentoConcedido                                    ,TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeAbatimento },
            { EnumCodigoMovimento_Sicoob.AbatimentoCancelado                                    ,TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeCancelamentoAbatimento },
            { EnumCodigoMovimento_Sicoob.VencimentoAlterado                                     ,TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoAlteracaoDeVencimento },
            { EnumCodigoMovimento_Sicoob.LiquidacaoAposBaixa                                    ,TipoOcorrenciaRetorno.LiquidacaoAposBaixaOuLiquidacaoTituloNaoRegistrado },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDeRecebimentoDeInstrucaoDeProtesto          ,TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeProtesto },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDeRecebimentoDeInstrucaoDeSustacaoDeProtesto,TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeSustacaoCancelamentoDeProtesto },
            { EnumCodigoMovimento_Sicoob.EntradaDeTituloEmCartorio                              ,TipoOcorrenciaRetorno.RemessaACartorio },
            { EnumCodigoMovimento_Sicoob.Tarifa                                                 ,TipoOcorrenciaRetorno.DebitoDeTarifasCustas },
            { EnumCodigoMovimento_Sicoob.RejeicaoDoPagador                                      ,TipoOcorrenciaRetorno.OcorrenciasDoPagador },
            { EnumCodigoMovimento_Sicoob.AlteracaoRejeitada                                     ,TipoOcorrenciaRetorno.AlteracaoDeDadosRejeitada },
            { EnumCodigoMovimento_Sicoob.InstrucaoRejeitada                                     ,TipoOcorrenciaRetorno.InstrucaoRejeitada },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDePedidoDeAlteracaoDeOutrosDados            ,TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDosDadosDoRateioDeCredito },
            { EnumCodigoMovimento_Sicoob.RetiradoDeCartorioEManutencaoEmCarteira                ,TipoOcorrenciaRetorno.ConfirmacaoDoCancelamentoDosDadosDoRateioDeCredito },
            { EnumCodigoMovimento_Sicoob.TituloEmSer                                            ,TipoOcorrenciaRetorno.TitulosEmCarteira },
            { EnumCodigoMovimento_Sicoob.TransferenciaModadalidadeCobranca                      ,TipoOcorrenciaRetorno.ConfirmacaoDeinstrucaoDetransferenciaDecarteiraModalidadeDecobrança},
            { EnumCodigoMovimento_Sicoob.ConfirmacaoInstrucaoDesconto                           ,TipoOcorrenciaRetorno.ConfirmacaoDoRecebimentoDaInstrucaoDeDesconto },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoRecebimentoCancelamentoDesconto             ,TipoOcorrenciaRetorno.ConfirmacaoDoRecebimentoDoCancelamentoDoDesconto },
            { EnumCodigoMovimento_Sicoob.ProtestadoEBaixado                                     ,TipoOcorrenciaRetorno.ProtestadoEBaixado },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoEnvioSMS                                    ,TipoOcorrenciaRetorno.ConfirmacaoDeEnvioDeEmailSMS },
            { EnumCodigoMovimento_Sicoob.EnvioSMSRejeitado                                      ,TipoOcorrenciaRetorno.EnvioDeEmailSMSRejeitado },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoPrazoRececimento                   ,TipoOcorrenciaRetorno.ConfirmacaoDeAlteracaoDoPrazoLimiteDeRecebimento },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDispensaPrazoLimiteRecebimento              ,TipoOcorrenciaRetorno.ConfirmacaoDeDispensaDePrazoLimiteDeRecebimento },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoNumeroTitulo                       ,TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDonumeroDoTitulodadoPeloBeneficiário },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAteracaoNumeroParticipante                  ,TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDonumeroControleDoParticipante },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoDadosPagador                       ,TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDosdadosDoPagador },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoDadosPagadorAvalista               ,TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDosdadosDoSacadorAvalista },
            { EnumCodigoMovimento_Sicoob.TituloPagoComChequeDevolvido                           ,TipoOcorrenciaRetorno.TitulopagoComChequeDevolvido },
            { EnumCodigoMovimento_Sicoob.TituloPagoComChequeCompensado                          ,TipoOcorrenciaRetorno.TitulopagoComChequeCompensado },
            { EnumCodigoMovimento_Sicoob.InstrucaoParacancelarProtestoConfirmada                ,TipoOcorrenciaRetorno.InstrucaoParacancelarProtestoConfirmada },
            { EnumCodigoMovimento_Sicoob.InstrucaoParaProtestoParaFinsFalimentaresConfirmada    ,TipoOcorrenciaRetorno.InstrucaoParaprotestoParafinsFalimentaresConfirmada },
            { EnumCodigoMovimento_Sicoob.AlteracaoContratoCobranca                              ,TipoOcorrenciaRetorno.AlteracaoDecontratoDecobranca },
            { EnumCodigoMovimento_Sicoob.TituloPagoComChequePendenteLiquidacao                  ,TipoOcorrenciaRetorno.TitulopagoComchequePendenteDeliquidacao },
            { EnumCodigoMovimento_Sicoob.TituloDDAReconhecidoPeloPagador                        ,TipoOcorrenciaRetorno.TituloDDAreconhecidoPeloPagador },
            { EnumCodigoMovimento_Sicoob.TituloDDANaoReconhecidoPeloPagador                     ,TipoOcorrenciaRetorno.TituloDDANaoReconhecidoPeloPagador },
            { EnumCodigoMovimento_Sicoob.TituloDDARecusadoCIP                                   ,TipoOcorrenciaRetorno.TituloDDArecusadoPelaCIP },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoBaixaTituloNegativoSemProtesto              ,TipoOcorrenciaRetorno.ConfirmacaoDaInstrucaoDeBaixaDeTituloNegativadoSemProtesto },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoDispensaMulta                         ,TipoOcorrenciaRetorno.ConfirmacaoDePedidoDeDispensaDeMulta },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoCobrancaMulta                         ,TipoOcorrenciaRetorno.ConfirmacaoDoPedidoDeCobrancaDeMulta },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoAlteracaoCobrancaJuros                ,TipoOcorrenciaRetorno.ConfirmacaoDoPedidoDeAlteracaoDeCobrancaDeJuros },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoAlteracaoValorDataDesconto            ,TipoOcorrenciaRetorno.ConfirmacaoDoPedidoDeAlteracaoDoValorDataDeDesconto },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoAlteracaoBeneficiario                 ,TipoOcorrenciaRetorno.ConfirmacaoDoPedidoDeAlteracaoDoBeneficiarioDoTítulo },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoDispensaJurosMora                     ,TipoOcorrenciaRetorno.ConfirmacaoDoPedidoDeDispensaDeJurosDeMora },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDesistenciaProtesto                         ,TipoOcorrenciaRetorno.ConfirmacaoDesistenciaProtesto },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoCancelamentoProtesto                        ,TipoOcorrenciaRetorno.ConfirmacaoCancelamentoProtesto }
        };

        private Dictionary<EnumCodigoMovimento_Sicoob, string> descricoes = new Dictionary<EnumCodigoMovimento_Sicoob, string>()
        {
            { EnumCodigoMovimento_Sicoob.EntradaConfirmada                                             , "Entrada confirmada"                                                       },
            { EnumCodigoMovimento_Sicoob.EntradaRejeitada                                              , "Entrada rejeitada"                                                        },
            { EnumCodigoMovimento_Sicoob.TransferenciaDeCarteiraEntrada                                , "Transferência de Carteira/Entrada"                                        },
            { EnumCodigoMovimento_Sicoob.TransferenciaDeCarteiraBaixa                                  , "Transferência de Carteira/Baixa"                                          },
            { EnumCodigoMovimento_Sicoob.LiquidacaoNormal                                              , "Liquidação normal"                                                        },
            { EnumCodigoMovimento_Sicoob.Baixado                                                       , "Baixa de Título"                                                          },
            { EnumCodigoMovimento_Sicoob.BaixadoConformeInstrucoesDaCooperativaDeCredito               , "Baixado conforme instruções da cooperativa de crédito"                    },
            { EnumCodigoMovimento_Sicoob.AbatimentoConcedido                                           , "Abatimento concedido"                                                     },
            { EnumCodigoMovimento_Sicoob.AbatimentoCancelado                                           , "Abatimento cancelado"                                                     },
            { EnumCodigoMovimento_Sicoob.VencimentoAlterado                                            , "Vencimento alterado"                                                      },
            { EnumCodigoMovimento_Sicoob.LiquidacaoEmCartorio                                          , "Liquidação em cartório"                                                   },
            { EnumCodigoMovimento_Sicoob.LiquidacaoAposBaixa                                           , "Liquidação após baixa"                                                    },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDeRecebimentoDeInstrucaoDeProtesto                 , "Confirmação de recebimento de instrução de protesto"                      },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDeRecebimentoDeInstrucaoDeSustacaoDeProtesto       , "Confirmação de recebimento de instrução de sustação de protesto"          },
            { EnumCodigoMovimento_Sicoob.EntradaDeTituloEmCartorio                                     , "Entrada de título em cartório"                                            },
            { EnumCodigoMovimento_Sicoob.EntradaRejeitadaPorCEPIrregular                               , "Entrada rejeitada por CEP irregular"                                      },
            { EnumCodigoMovimento_Sicoob.BaixaRejeitada                                                , "Baixa rejeitada"                                                          },
            { EnumCodigoMovimento_Sicoob.Tarifa                                                        , "Tarifa"                                                                   },
            { EnumCodigoMovimento_Sicoob.RejeicaoDoPagador                                             , "Rejeição do pagador"                                                      },
            { EnumCodigoMovimento_Sicoob.AlteracaoRejeitada                                            , "Alteração rejeitada"                                                      },
            { EnumCodigoMovimento_Sicoob.InstrucaoRejeitada                                            , "Instrução rejeitada"                                                      },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDePedidoDeAlteracaoDeOutrosDados                   , "Confirmação de pedido de alteração de outros dados"                       },
            { EnumCodigoMovimento_Sicoob.RetiradoDeCartorioEManutencaoEmCarteira                       , "Retirado de cartório e manutenção em carteira"                            },
            { EnumCodigoMovimento_Sicoob.AceiteDoPagador                                               , "Aceite do pagador"                                                        },
            { EnumCodigoMovimento_Sicoob.TituloEmSer                                                   , "Título em Ser"                                                            },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoInstrucaoDesconto                                  , "Confirmação do Recebimento da Instrução de Desconto"                      },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoRecebimentoCancelamentoDesconto                    , "Confirmação do Recebimento do Cancelamento do Desconto"                   },
            { EnumCodigoMovimento_Sicoob.ProtestadoEBaixado                                            , "Protestado e Baixado (Baixa por Ter Sido Protestado)"                     },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoEnvioSMS                                           , "Confirmação de envio de e-mail/SMS"                                       },
            { EnumCodigoMovimento_Sicoob.EnvioSMSRejeitado                                             , "Envio de e-mail/SMS rejeitado"                                            },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoPrazoRececimento                          , "Confirmação de alteração do Prazo Limite de Recebimento (a data deve ser" },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDispensaPrazoLimiteRecebimento                     , "Confirmação de Dispensa de Prazo Limite de Recebimento"                   },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoNumeroTitulo                              , "Confirmação da alteração do número do título dado pelo Beneficiário"      },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAteracaoNumeroParticipante                         , "Confirmação da alteração do número controle do Participante"              },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoDadosPagador                              , "Confirmação da alteração dos dados do Pagador"                            },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoAlteracaoDadosPagadorAvalista                      , "Confirmação da alteração dos dados do Pagadorr/Avalista"                  },
            { EnumCodigoMovimento_Sicoob.TituloPagoComChequeDevolvido                                  , "Título pago com cheque devolvido"                                         },
            { EnumCodigoMovimento_Sicoob.TituloPagoComChequeCompensado                                 , "Título pago com cheque compensado"                                        },
            { EnumCodigoMovimento_Sicoob.InstrucaoParacancelarProtestoConfirmada                       , "Instrução para cancelar protesto confirmada"                              },
            { EnumCodigoMovimento_Sicoob.InstrucaoParaProtestoParaFinsFalimentaresConfirmada           , "Instrução para protesto para fins falimentares confirmada"                },
            { EnumCodigoMovimento_Sicoob.AlteracaoContratoCobranca                                     , "Alteração de contrato de cobrança"                                        },
            { EnumCodigoMovimento_Sicoob.TituloPagoComChequePendenteLiquidacao                         , "Título pago com cheque pendente de liquidação"                            },
            { EnumCodigoMovimento_Sicoob.TituloDDAReconhecidoPeloPagador                               , "Título DDA reconhecido pelo Pagador"                                      },
            { EnumCodigoMovimento_Sicoob.TituloDDANaoReconhecidoPeloPagador                            , "Título DDA não reconhecido pelo Pagador"                                  },
            { EnumCodigoMovimento_Sicoob.TituloDDARecusadoCIP                                          , "Título DDA recusado pela CIP"                                             },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoBaixaTituloNegativoSemProtesto                     , "Confirmação da Instrução de Baixa de Título Negativado sem Protesto"      },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoDispensaMulta                                , "Confirmação de Pedido de Dispensa de Multa"                               },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoCobrancaMulta                                , "Confirmação do Pedido de Cobrança de Multa"                               },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoAlteracaoCobrancaJuros                       , "Confirmação do Pedido de Alteração de Cobrança de Juros"                  },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoAlteracaoValorDataDesconto                   , "Confirmação do Pedido de Alteração do Valor/Data de Desconto"             },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoAlteracaoBeneficiario                        , "Confirmação do Pedido de Alteração do Beneficiário do Título"             },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoPedidoDispensaJurosMora                            , "Confirmação do Pedido de Dispensa de Juros de Mora"                       },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoDesistenciaProtesto                                , "Confirmação de Desistência de Protesto"                                   },
            { EnumCodigoMovimento_Sicoob.ConfirmacaoCancelamentoProtesto                               , "Confirmação de cancelamento do Protesto"                                  },
            { EnumCodigoMovimento_Sicoob.TransferenciaModadalidadeCobranca                             , "Transferencia de modalidade de cobrança"                                  }

        };
        #endregion
    }
}
