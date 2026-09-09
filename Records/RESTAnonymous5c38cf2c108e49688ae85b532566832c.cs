using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestCancelRecord
public class RESTRC_0e3fdf026f72a52d5ce82006854e2d4b : AbstractRESTStructure<RC_0e3fdf026f72a52d5ce82006854e2d4b> {
[JsonProperty("EntryOrderRequestCancel")]
public ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure AttrEntryOrderRequestCancel;

public RESTRC_0e3fdf026f72a52d5ce82006854e2d4b() { }

public RESTRC_0e3fdf026f72a52d5ce82006854e2d4b (RC_0e3fdf026f72a52d5ce82006854e2d4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntryOrderRequestCancel = ConvertToRestWithoutDefaults(s.ssSTEntryOrderRequestCancel, new ST_ed201ff180bb2dd4a51ad889e8debcfaStructure(), ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure.FromStructure, config);
  } else {
AttrEntryOrderRequestCancel = ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure.FromStructure(s.ssSTEntryOrderRequestCancel, config);
  }
}

public static RC_0e3fdf026f72a52d5ce82006854e2d4b ToStructure(ssConectaProveedores.RestRecords.RESTRC_0e3fdf026f72a52d5ce82006854e2d4b obj) { 
  RC_0e3fdf026f72a52d5ce82006854e2d4b s = new RC_0e3fdf026f72a52d5ce82006854e2d4b();
  if(obj != null) {
  s.ssSTEntryOrderRequestCancel = ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure.ToStructure(obj.AttrEntryOrderRequestCancel);
  }
  return s;
}

public static Func<RC_0e3fdf026f72a52d5ce82006854e2d4b, ssConectaProveedores.RestRecords.RESTRC_0e3fdf026f72a52d5ce82006854e2d4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e3fdf026f72a52d5ce82006854e2d4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0e3fdf026f72a52d5ce82006854e2d4b FromStructure(RC_0e3fdf026f72a52d5ce82006854e2d4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0e3fdf026f72a52d5ce82006854e2d4b(s, config);
}

}


