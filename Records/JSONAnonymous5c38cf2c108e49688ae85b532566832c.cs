using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestCancelRecord
public class JSONRC_0e3fdf026f72a52d5ce82006854e2d4b : AbstractRESTStructure<RC_0e3fdf026f72a52d5ce82006854e2d4b> {
[JsonProperty("EntryOrderRequestCancel")]
[JsonPropertyName("EntryOrderRequestCancel")]
public ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure AttrEntryOrderRequestCancel;

public JSONRC_0e3fdf026f72a52d5ce82006854e2d4b() { }

public JSONRC_0e3fdf026f72a52d5ce82006854e2d4b (RC_0e3fdf026f72a52d5ce82006854e2d4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntryOrderRequestCancel = ConvertToRestWithoutDefaults(s.ssSTEntryOrderRequestCancel, new ST_ed201ff180bb2dd4a51ad889e8debcfaStructure(), ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure.FromStructure, config);
  } else {
AttrEntryOrderRequestCancel = ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure.FromStructure(s.ssSTEntryOrderRequestCancel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0e3fdf026f72a52d5ce82006854e2d4b, RC_0e3fdf026f72a52d5ce82006854e2d4b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0e3fdf026f72a52d5ce82006854e2d4b s) => ToStructure(s, config);
}
public static RC_0e3fdf026f72a52d5ce82006854e2d4b ToStructure(ssConectaProveedores.RestRecords.JSONRC_0e3fdf026f72a52d5ce82006854e2d4b obj, IBehaviorsConfiguration config) { 
  RC_0e3fdf026f72a52d5ce82006854e2d4b s = new RC_0e3fdf026f72a52d5ce82006854e2d4b();
  if(obj != null) {
  s.ssSTEntryOrderRequestCancel = ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure.ToStructure(obj.AttrEntryOrderRequestCancel, config);
  }
  return s;
}

public static Func<RC_0e3fdf026f72a52d5ce82006854e2d4b, ssConectaProveedores.RestRecords.JSONRC_0e3fdf026f72a52d5ce82006854e2d4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e3fdf026f72a52d5ce82006854e2d4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0e3fdf026f72a52d5ce82006854e2d4b FromStructure(RC_0e3fdf026f72a52d5ce82006854e2d4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0e3fdf026f72a52d5ce82006854e2d4b(s, config);
}

}


