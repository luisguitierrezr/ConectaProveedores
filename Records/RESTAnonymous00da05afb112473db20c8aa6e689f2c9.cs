using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemEMRecord
public class RESTRC_61508c4f51e53175a4e20d5c4af9d10b : AbstractRESTStructure<RC_61508c4f51e53175a4e20d5c4af9d10b> {
[JsonProperty("ItemEM")]
public ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure AttrItemEM;

public RESTRC_61508c4f51e53175a4e20d5c4af9d10b() { }

public RESTRC_61508c4f51e53175a4e20d5c4af9d10b (RC_61508c4f51e53175a4e20d5c4af9d10b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemEM = ConvertToRestWithoutDefaults(s.ssSTItemEM, new ST_6a8665543a0f720f26db84a82f35885fStructure(), ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.FromStructure, config);
  } else {
AttrItemEM = ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.FromStructure(s.ssSTItemEM, config);
  }
}

public static RC_61508c4f51e53175a4e20d5c4af9d10b ToStructure(ssConectaProveedores.RestRecords.RESTRC_61508c4f51e53175a4e20d5c4af9d10b obj) { 
  RC_61508c4f51e53175a4e20d5c4af9d10b s = new RC_61508c4f51e53175a4e20d5c4af9d10b();
  if(obj != null) {
  s.ssSTItemEM = ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.ToStructure(obj.AttrItemEM);
  }
  return s;
}

public static Func<RC_61508c4f51e53175a4e20d5c4af9d10b, ssConectaProveedores.RestRecords.RESTRC_61508c4f51e53175a4e20d5c4af9d10b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_61508c4f51e53175a4e20d5c4af9d10b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_61508c4f51e53175a4e20d5c4af9d10b FromStructure(RC_61508c4f51e53175a4e20d5c4af9d10b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_61508c4f51e53175a4e20d5c4af9d10b(s, config);
}

}


