using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownOptionalConfigsRecord
public class RESTRC_2ac88c51f2d9ed908454e6a06ffe188e : AbstractRESTStructure<RC_2ac88c51f2d9ed908454e6a06ffe188e> {
[JsonProperty("DropdownOptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure AttrDropdownOptionalConfigs;

public RESTRC_2ac88c51f2d9ed908454e6a06ffe188e() { }

public RESTRC_2ac88c51f2d9ed908454e6a06ffe188e (RC_2ac88c51f2d9ed908454e6a06ffe188e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownOptionalConfigs, new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure(), ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure.FromStructure, config);
  } else {
AttrDropdownOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure.FromStructure(s.ssSTDropdownOptionalConfigs, config);
  }
}

public static RC_2ac88c51f2d9ed908454e6a06ffe188e ToStructure(ssConectaProveedores.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e obj) { 
  RC_2ac88c51f2d9ed908454e6a06ffe188e s = new RC_2ac88c51f2d9ed908454e6a06ffe188e();
  if(obj != null) {
  s.ssSTDropdownOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_4e53cb8815b86020ced1d2f2652c9b1dStructure.ToStructure(obj.AttrDropdownOptionalConfigs);
  }
  return s;
}

public static Func<RC_2ac88c51f2d9ed908454e6a06ffe188e, ssConectaProveedores.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2ac88c51f2d9ed908454e6a06ffe188e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e FromStructure(RC_2ac88c51f2d9ed908454e6a06ffe188e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2ac88c51f2d9ed908454e6a06ffe188e(s, config);
}

}


