using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Services.Models
{
    public class ServiceItem: SitecoreItem
    {
        //OBS: Quando um campo do template tiver nome composto, devemos usar a seguinte tag
        // Exemplo: o campo do template é: Imagem Link
        // A tag usada deve ser: [SitecoreField("Imagem Link")] logo acima do parametro declarado.

        public Image ImagemIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}