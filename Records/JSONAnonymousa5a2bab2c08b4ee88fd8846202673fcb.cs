using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemStatusRecord
public class JSONRC_eadaf2f9446fb019e39088d303bee2ef : AbstractRESTStructure<RC_eadaf2f9446fb019e39088d303bee2ef> {
[JsonProperty("OrderMainItemStatus")]
[JsonPropertyName("OrderMainItemStatus")]
public ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord AttrOrderMainItemStatus;

public JSONRC_eadaf2f9446fb019e39088d303bee2ef() { }

public JSONRC_eadaf2f9446fb019e39088d303bee2ef (RC_eadaf2f9446fb019e39088d303bee2ef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItemStatus = ConvertToRestWithoutDefaults(s.ssENOrderMainItemStatus, new EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItemStatus = ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.FromStructure(s.ssENOrderMainItemStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_eadaf2f9446fb019e39088d303bee2ef, RC_eadaf2f9446fb019e39088d303bee2ef> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_eadaf2f9446fb019e39088d303bee2ef s) => ToStructure(s, config);
}
public static RC_eadaf2f9446fb019e39088d303bee2ef ToStructure(ssConectaProveedores.RestRecords.JSONRC_eadaf2f9446fb019e39088d303bee2ef obj, IBehaviorsConfiguration config) { 
  RC_eadaf2f9446fb019e39088d303bee2ef s = new RC_eadaf2f9446fb019e39088d303bee2ef();
  if(obj != null) {
  s.ssENOrderMainItemStatus = ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.ToStructure(obj.AttrOrderMainItemStatus, config);
  }
  return s;
}

public static Func<RC_eadaf2f9446fb019e39088d303bee2ef, ssConectaProveedores.RestRecords.JSONRC_eadaf2f9446fb019e39088d303bee2ef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eadaf2f9446fb019e39088d303bee2ef s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_eadaf2f9446fb019e39088d303bee2ef FromStructure(RC_eadaf2f9446fb019e39088d303bee2ef s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_eadaf2f9446fb019e39088d303bee2ef(s, config);
}

}


