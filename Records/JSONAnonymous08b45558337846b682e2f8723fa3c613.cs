using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM_RMRecord
public class JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b : AbstractRESTStructure<RC_c3fffd52ae72b7942dcb46e5cfbb700b> {
[JsonProperty("PI_ITEM_EM_RM")]
[JsonPropertyName("PI_ITEM_EM_RM")]
public ssConectaProveedores.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure AttrPI_ITEM_EM_RM;

public JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b() { }

public JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b (RC_c3fffd52ae72b7942dcb46e5cfbb700b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM_RM = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM_RM, new ST_9689a124a3af07dbe86be1015d9b7bb1Structure(), ssConectaProveedores.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure.FromStructure, config);
  } else {
AttrPI_ITEM_EM_RM = ssConectaProveedores.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure.FromStructure(s.ssSTPI_ITEM_EM_RM, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b, RC_c3fffd52ae72b7942dcb46e5cfbb700b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b s) => ToStructure(s, config);
}
public static RC_c3fffd52ae72b7942dcb46e5cfbb700b ToStructure(ssConectaProveedores.RestRecords.JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b obj, IBehaviorsConfiguration config) { 
  RC_c3fffd52ae72b7942dcb46e5cfbb700b s = new RC_c3fffd52ae72b7942dcb46e5cfbb700b();
  if(obj != null) {
  s.ssSTPI_ITEM_EM_RM = ssConectaProveedores.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure.ToStructure(obj.AttrPI_ITEM_EM_RM, config);
  }
  return s;
}

public static Func<RC_c3fffd52ae72b7942dcb46e5cfbb700b, ssConectaProveedores.RestRecords.JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c3fffd52ae72b7942dcb46e5cfbb700b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b FromStructure(RC_c3fffd52ae72b7942dcb46e5cfbb700b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c3fffd52ae72b7942dcb46e5cfbb700b(s, config);
}

}


