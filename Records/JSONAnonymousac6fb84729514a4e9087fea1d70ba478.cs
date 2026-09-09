using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueItem2Record
public class JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7 : AbstractRESTStructure<RC_f8549493bcd7ba8b9e84758a4cb06ac7> {
[JsonProperty("ValueItem2")]
[JsonPropertyName("ValueItem2")]
public ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure AttrValueItem2;

public JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7() { }

public JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7 (RC_f8549493bcd7ba8b9e84758a4cb06ac7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValueItem2 = ConvertToRestWithoutDefaults(s.ssSTValueItem2, new ST_7d9cb56357295234b770124829cebf1bStructure(), ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure.FromStructure, config);
  } else {
AttrValueItem2 = ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure.FromStructure(s.ssSTValueItem2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7, RC_f8549493bcd7ba8b9e84758a4cb06ac7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7 s) => ToStructure(s, config);
}
public static RC_f8549493bcd7ba8b9e84758a4cb06ac7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7 obj, IBehaviorsConfiguration config) { 
  RC_f8549493bcd7ba8b9e84758a4cb06ac7 s = new RC_f8549493bcd7ba8b9e84758a4cb06ac7();
  if(obj != null) {
  s.ssSTValueItem2 = ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure.ToStructure(obj.AttrValueItem2, config);
  }
  return s;
}

public static Func<RC_f8549493bcd7ba8b9e84758a4cb06ac7, ssConectaProveedores.RestRecords.JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f8549493bcd7ba8b9e84758a4cb06ac7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7 FromStructure(RC_f8549493bcd7ba8b9e84758a4cb06ac7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f8549493bcd7ba8b9e84758a4cb06ac7(s, config);
}

}


