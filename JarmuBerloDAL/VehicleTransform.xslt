<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <html>
    <meta http-equiv="content-Type" content="text/html; charset=UTF-8" />
    <body style="background-color:#B2E0FF">
      <center><h1>Járművek</h1></center>
      <xsl:for-each select="//Kategoria">
        <h2><u>
          <xsl:value-of select="@KategoriaNev"/><xsl:if test="not(contains(@KategoriaNev, 'ó'))">o</xsl:if>k (<xsl:value-of select="@Ferohelyek"/> férőhely)
        </u></h2>
        <table width="50%" border="1" style="border-collapse:collapse;margin-top:-20px;margin-left:15px;background-color:#F4F4F4;font-size:18px">
          <tr style="background-color:#87B2F3">
            <th width ="25%">Gyártó</th>
            <th width ="25%">Modell</th>
            <th width ="17%">Gyártás éve</th>
            <th width ="16%">Napidíj</th>
            <th width ="16%">Fogyasztás</th>
          </tr>
          <xsl:for-each select="./Jarmu">
            <tr>
              <td><xsl:value-of select="GyartoNev"/></td>
              <td><xsl:value-of select="Modell"/></td>
              <td><xsl:value-of select="KiadasEve"/></td>
              <td><xsl:value-of select="Napidij"/></td>
              <td><xsl:value-of select="Fogyasztas"/></td>
            </tr>
          </xsl:for-each>
        </table>
      </xsl:for-each>
    </body>
    </html>
  </xsl:template>
  
</xsl:stylesheet>
