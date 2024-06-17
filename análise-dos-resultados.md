# Análise dos resumos resultantes

## Resultados

Utilizamos um decreto de lei não presente no corpus para avaliar os métodos desenvolvidos. A seguir apresentamos os resultados:

### Resumo Simbólico Baseado em Regras:

 O Decreto nº 9.628, de 17 DE NOVEMBRO DE 2023. As limitações de recursos fazem com que o Conselho Superior de Governança do Ministério da Defesa (CONSUG/MD) tenha de estabelecer, para o ciclo de gestão 2024-2027, a priorização dos OSD, das Iniciativas Estratégicas de Defesa (IED) e métricas correspondentes, ou seja, aqueles que receberão maior ênfase no período considerado, destacando que a priorização não significa exclusividade para o desenvolvimento ou aplicação de recursos. Aprimorar o relacionamento internacional de defesa, em consonância com os interesses nacionais e a política externa, para promover a confiança mútua, a cooperação e o estreitamento de laços de amizade entre as nações, visando à solução pacífica de eventuais conflitos, além de contribuir para a paz e a segurança internacionais.
 
### Resumo Baseado em Frequências das Palavras:

 O Decreto nº 9.628, de 17 DE NOVEMBRO DE 2023. Fortalecer o setor de ciência, tecnologia e inovação das Forças Armadas, a área de ciência e tecnologia de interesse da Defesa Nacional, contribuir para o fortalecimento da Base Industrial de Defesa (BID) e o aperfeiçoamento da integração da tríade governo-indústria-academia para o domínio e o uso de tecnologias de interesse da defesa. Missão - preparar as Forças Armadas, mantendo-as em permanente estado de prontidão para serem empregadas na defesa da Pátria, na garantia dos poderes constitucionais, na garantia da lei e da ordem; no cumprimento das atribuições subsidiárias; e em apoio à política externa; a fim de contribuir com o esforço nacional de defesa. As limitações de recursos fazem com que o Conselho Superior de Governança do Ministério da Defesa (CONSUG/MD) tenha de estabelecer, para o ciclo de gestão 2024-2027, a priorização dos OSD, das Iniciativas Estratégicas de Defesa (IED) e métricas correspondentes, ou seja, aqueles que receberão maior ênfase no período considerado, destacando que a priorização não significa exclusividade para o desenvolvimento ou aplicação de recursos.
 
### Resumo Baseado em TF-IDF:

 O Decreto nº 9.628, de 17 DE NOVEMBRO DE 2023. As limitações de recursos fazem com que o Conselho Superior de Governança do Ministério da Defesa (CONSUG/MD) tenha de estabelecer, para o ciclo de gestão 2024-2027, a priorização dos OSD, das Iniciativas Estratégicas de Defesa (IED) e métricas correspondentes, ou seja, aqueles que receberão maior ênfase no período considerado, destacando que a priorização não significa exclusividade para o desenvolvimento ou aplicação de recursos. Sustentação - aptidão para prover o apoio necessário às operações militares e às atividades inerentes ao cumprimento das atribuições de determinada força, compreendida como o conjunto de unidades integradas por navios, aeronaves, tropas ou pela combinação desses componentes, que dispõe de comando próprio e é estabelecida para fins administrativos, operacionais ou logísticos. Estimular a realização de estudos e debates sobre temas ligados à defesa nacional no setor de defesa e na sociedade brasileira, particularmente no meio acadêmico, bem como a inserção do assunto no sistema educacional do país, com o propósito de ampliar o conhecimento de assunto que afeta a existência da nação como ente soberano e respeitado na comunidade internacional.
 
### Resumo Baseado em LSA:

 O Decreto nº 9.628, de 17 DE NOVEMBRO DE 2023. A Cadeia de Valor do Setor de Defesa foi aprovada pela Resolução CONSUG/MD nº 6, de 11 de novembro de 2020. As metas e os indicadores estratégicos a serem empregados para o acompanhamento da implementação do PESD 2020-2031 para o período 2024 - 2027, relacionados com os OSD priorizados neste Plano, serão os contidos no Painel de Indicadores e Metas, aprovado pela Portaria GM-MD nº 5.536, de 8 de novembro de 2022. As limitações de recursos fazem com que o Conselho Superior de Governança do Ministério da Defesa (CONSUG/MD) tenha de estabelecer, para o ciclo de gestão 2024-2027, a priorização dos OSD, das Iniciativas Estratégicas de Defesa (IED) e métricas correspondentes, ou seja, aqueles que receberão maior ênfase no período considerado, destacando que a priorização não significa exclusividade para o desenvolvimento ou aplicação de recursos.
 
### Resumo utilizando modelo do HuggingFace:

Setor de Defesa é aprovado pela Resoluço ConSUG/MD no 6, de 26 de dezembro de 2018, e apresenta o Plano Estratégico Setorial 2024-2027, com os objetivos de recursos para o desenvolvimento nacional, a integrar a manobra, o engajamento, integridade nacionais, atividades e inovaçes, em diversas áreas de responsabilidade do Estado brasileiro. O Plano Plurianual 2024/2027 tem o preparamento de estudos, incluindo inteligência, vigilância, meteorologia e oceanografia, ampliar o conhecimento dos medidas e facilitar esforço da cidadania.


## Análise dos Resumos

O documento original, encontrado no arquivo `input-test.txt`, é um texto formal publicado no Diário Oficial da União, detalhando a Resolução CONSUG-MD Nº 17, de 17 de novembro de 2023, que aprova o Plano Estratégico Setorial 2024-2027 do Ministério da Defesa. Este plano estratégico foca em estabelecer prioridades para a implementação do Planejamento Estratégico Setorial de Defesa, com ênfase na alinhamento entre planejamento estratégico e orçamentário. O texto cobre múltiplas áreas, desde macroprocessos da Cadeia de Valor do Setor de Defesa até objetivos setoriais específicos para o desenvolvimento e a defesa nacionais. Ele é densamente informativo, contendo terminologias específicas de gestão e defesa, e está estruturado em seções que delineiam objetivos, considerações iniciais, alinhamento com estratégias nacionais, e mais.

**Análise dos Resumos:**

1. **Resumo Simbólico:** Foca em aspectos de priorização de iniciativas estratégicas dentro de limitações de recursos, e na importância das relações internacionais para a defesa. Captura a essência das priorizações estratégicas do texto, mas omite detalhes sobre a estrutura específica e objetivos detalhados do plano.

2. **Resumo Baseado em Frequências das Palavras:** Este resumo captura uma variedade mais ampla de tópicos discutidos no texto, incluindo a preparação das Forças Armadas, integração entre governo, indústria e academia, e o foco em ciência, tecnologia e inovação. Ele aborda mais conteúdo que o resumo simbólico, fornecendo uma visão mais holística do documento.

3. **Resumo Baseado em TF-IDF:** Este resumo inclui detalhes sobre a sustentação das operações militares e a promoção de estudos e debates sobre defesa nacional. Ele é eficaz em destacar alguns dos elementos únicos e importantes do texto que podem ser menos frequentes, mas críticos para a compreensão das estratégias de defesa.

4. **Resumo Baseado em LSA:** Este resumo menciona especificamente a Cadeia de Valor do Setor de Defesa e metas estratégicas para o período 2024-2027. Ele lida com aspectos mais técnicos e administrativos do plano, mas, como o TF-IDF, oferece uma perspectiva valiosa sobre os componentes estruturais do plano.

5. **Resumo utilizando modelo do HuggingFace:** Esse resumo parece abordar uma mistura de pontos chave, introduzindo aspectos do plano estratégico setorial e seus objetivos ampliados, como desenvolvimento nacional e atividades de defesa específicas. No entanto, parece um pouco desconexo em termos de fluidez e integração dos tópicos.

**Análise Comparativa:**

Cada resumo oferece uma visão diferente do texto original, refletindo diferentes aspectos deste documento complexo:

- O **Resumo Simbólico** e o **Resumo utilizando modelo do HuggingFace** se concentram mais nas priorizações e implicações de alto nível, sendo úteis para entender rapidamente as principais intenções estratégicas do plano.
- O **Resumo Baseado em Frequências das Palavras** oferece uma visão mais balanceada, cobrindo uma gama ampla de tópicos abordados no texto completo.
- Os resumos **Baseado em TF-IDF** e **Baseado em LSA** destacam componentes específicos e técnicos, sendo ideais para quem busca entender aspectos específicos da implementação e avaliação do plano.

Em termos de fidelidade e utilidade, o resumo baseado em frequências das palavras parece ser o mais equilibrado, capturando tanto o escopo quanto os detalhes essenciais do documento. Os métodos TF-IDF e LSA são úteis para destacar detalhes únicos, enquanto os resumos simbólicos e do HuggingFace são melhores para uma compreensão rápida e geral.


## Coesão dos Resultaddos

A coesão de um texto resumido é crucial para a sua compreensibilidade e eficácia em transmitir a mensagem principal do texto original. Aqui está uma avaliação da coesão nos resumos fornecidos, com base no arquivo `resultados.txt`:

1. **Resumo Simbólico:** Este resumo mantém uma coesão razoável, ligando as priorizações estratégicas com os objetivos de relações internacionais. Contudo, há uma certa falta de transição suave entre os tópicos de priorização de recursos e relações internacionais, o que pode deixar o leitor um pouco desorientado sobre como os temas estão conectados.

2. **Resumo Baseado em Frequências das Palavras:** A coesão aqui é um pouco fragmentada. Embora cubra uma ampla gama de tópicos, o resumo parece uma lista de pontos importantes sem uma integração ou transição clara entre eles. Isso pode tornar mais difícil para o leitor entender como os diferentes elementos estão relacionados dentro do plano estratégico.

3. **Resumo Baseado em TF-IDF:** Este resumo é mais coeso que o anterior, pois parece construir uma narrativa mais focada em torno das priorizações dentro das limitações de recursos, sustentação das forças e incentivo aos estudos de defesa. A inclusão de tópicos menos frequentes, mas significativos, ajuda a conectar pontos distintos do texto original.

4. **Resumo Baseado em LSA:** Este resumo é coeso em termos de foco nos aspectos administrativos e estratégicos do plano. Ele vincula os conceitos de Cadeia de Valor, metas e priorizações de forma que o leitor possa entender como esses componentes se inter-relacionam.

5. **Resumo utilizando modelo do HuggingFace:** Este resumo parece ser o menos coeso dos cinco. Ele salta entre diferentes tópicos – desde a aprovação de planos até aspectos específicos como meteorologia e inteligência – sem transições claras ou um fio condutor que amarre os conceitos de maneira lógica e fluida.