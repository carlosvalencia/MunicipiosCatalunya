using System.Collections.Generic;
using System.IO;


namespace MunicipiosCatalunya
{

  public class ItemGeo
  {
    public int id { get; set; }
    public string nom { get; set; }
  }

  class GeoMuni
  {

    /*
     * La clase facilita información de los municipios, provincias y comarcas
     * en Catalunya, adquiere los datos desde el archivo binario .dat y los
     * traslada a matrices de tipo ItemGeo:
     * 
     * ItemGeo[x].id = código INE en número.
     * ItemGeo[x].nom = nombre de municipio, comarca o provincia.
     * 
     * 
     *  Para relacionar el municipio con sus comarca y provincia
     *  utiliza dos matrices tipo int[,]
     * 
     */


    /*
     * Ruta al archivo binario .dat con los datos
     */
    private string pathGeoMuni = Directory.GetCurrentDirectory() + @"\\MunicipiosCatalunya.dat";

    /*
     * Número de elementos, utilizadas en los bucles
     */
    private int sonProvincias;
    private int sonComarcas;
    private int sonMunicipios;

    /*
     * Matrices que relacionan el municipio con sus comarca y provincia
     */
    private int[,] idComarMuni = null;
    private int[,] idProvinMuni = null;

    /*
     * Matrices para los pares ItemGeo
     *
     * ItemGeo[x].id = código INE en número.
     * ItemGeo[x].nom = nombre de municipio, comarca o provincia.
     * 
     */
    private ItemGeo[] provincias;
    private ItemGeo[] comarcas;
    private ItemGeo[] municipios;


    /*
     * En el constructor, el parametro nomReal determina el nombre de los municipios
     * cargados desde el archivo binario .dat:
     * 
     * x = new GeoMUni(); o x = new Geomuni(true); 
     * nombres de municipios = su nombre real= el Bruc - l'Escala 
     * 
     * x = new GeoMUni(false);
     * nombres de municipios = nombre con el artículo al final, 
     * separado por una coma = Bruc, el - Escala, l'
     * 
     */
    public GeoMuni(bool nomReal = true)
    {
      LeeArchivoGeoMuni(nomReal);
    }


    public ItemGeo[] Provincias()
    {
      return provincias;
    }

    public ItemGeo[] Comarcas()
    {
      return comarcas;
    }

    public ItemGeo[] Municipios()
    {
      return municipios;
    }

    /* Retorna una List<ItemGeo> con los municipios
     * correspondientes a la provincia recibida
     */
    public List<ItemGeo> MunicipiosEnProvincia(int idProvincia)
    {
      List<ItemGeo> municipiosProvin = new List<ItemGeo>();

      for (int i = 0; i < sonMunicipios; i++)
      {
        if (idProvinMuni[0, 0] > idProvincia) break;
        if (idProvinMuni[i, 0] == idProvincia) municipiosProvin.Add(municipios[idProvinMuni[i, 1]]);
      }
      return municipiosProvin;
    }

    /* Retorna una List<ItemGeo> con los municipios
     * correspondientes a la comarca recibida
     */
    public List<ItemGeo> MunicipiosEnComarca(int idComarca)
    {
      List<ItemGeo> municipiosComarca = new List<ItemGeo>();

      for (int i = 0; i < sonMunicipios; i++)
      {
        if (idComarMuni[0, 0] > idComarca) break;
        if (idComarMuni[i, 0] == idComarca) municipiosComarca.Add(municipios[idComarMuni[i, 1]]);
      }
      return municipiosComarca;
    }

    /*
     * Lee el archivo binario con los datos e inicia las variables
     */
    private void LeeArchivoGeoMuni(bool nomReal)
    {
      if (!File.Exists(pathGeoMuni)) return;

      using (FileStream fs = File.OpenRead(pathGeoMuni))
      {
        using (BinaryReader lector = new BinaryReader(fs))
        {
          int offBloqueIndexado = lector.ReadInt32();
          sonProvincias = lector.ReadInt32();
          sonComarcas = lector.ReadInt32();
          sonMunicipios = lector.ReadInt32();

          // Iniciar las matrices ItemGeo para provincias y comarcas
          IniciaMatrizItemGeo(lector, sonProvincias, ref provincias);
          IniciaMatrizItemGeo(lector, sonComarcas, ref comarcas);

          // Se posiciona en el bloque de nombres con el artículo al final del nombre
          if (!nomReal) fs.Seek(offBloqueIndexado, SeekOrigin.Begin);

          // Iniciar la matriz ItemGeo para los municipios
          IniciaMatrizItemGeo(lector, sonMunicipios, ref municipios);

          // Inicia las matrices de relación municipio con su comarca y provincia
          IniciaMatrizRelaciones(lector, sonMunicipios, ref idProvinMuni);
          IniciaMatrizRelaciones(lector, sonMunicipios, ref idComarMuni);
        }
      }
    }



    /*
     * Crea la matriz ItemGeo[] y la inicia con los datos
     */
    private void IniciaMatrizItemGeo(BinaryReader lector, int son, ref ItemGeo[] matriz)
    {
      // Inicia la matriz de ItemGeo
      matriz = new ItemGeo[son];

      int i = 0;
      for (i = 0; i < son; i++) matriz[i] = new ItemGeo();

      // lee y procesa los datos del archivo
      string nombres = lector.ReadString();
      string[] temp = nombres.Split(';');

      i = 0;
      for (i = 0; i < son; i++)
      {
        matriz[i].id = lector.ReadInt32();
        matriz[i].nom = temp[i];
      }
    }

    /*
     * Crea la matriz in[,] y la inicia con los datos
     */
    private void IniciaMatrizRelaciones(BinaryReader lector, int son, ref int[,] matriz)
    {
      matriz = new int[son, 2];

      for (int i = 0; i < sonMunicipios; i++)
      {
        matriz[i, 0] = lector.ReadInt32();
        matriz[i, 1] = lector.ReadInt32();
      }
    }

  }
}
