namespace RelatorioProject.Dtos
{
    public class RelatorioCreateDto
    {
        public string Origem { get; set; }
        public string Destino { get; set; }        
        public double Valor { get; set; }
        public int Quantidade { get; set; }
    }
}