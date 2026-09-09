using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemStatusRecord
public class RESTRC_eadaf2f9446fb019e39088d303bee2ef : AbstractRESTStructure<RC_eadaf2f9446fb019e39088d303bee2ef> {
[JsonProperty("OrderMainItemStatus")]
public ssConectaProveedores.RestRecords.RESTEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord AttrOrderMainItemStatus;

public RESTRC_eadaf2f9446fb019e39088d303bee2ef() { }

public RESTRC_eadaf2f9446fb019e39088d303bee2ef (RC_eadaf2f9446fb019e39088d303bee2ef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItemStatus = ConvertToRestWithoutDefaults(s.ssENOrderMainItemStatus, new EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItemStatus = ssConectaProveedores.RestRecords.RESTEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.FromStructure(s.ssENOrderMainItemStatus, config);
  }
}

public static RC_eadaf2f9446fb019e39088d303bee2ef ToStructure(ssConectaProveedores.RestRecords.RESTRC_eadaf2f9446fb019e39088d303bee2ef obj) { 
  RC_eadaf2f9446fb019e39088d303bee2ef s = new RC_eadaf2f9446fb019e39088d303bee2ef();
  if(obj != null) {
  s.ssENOrderMainItemStatus = ssConectaProveedores.RestRecords.RESTEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.ToStructure(obj.AttrOrderMainItemStatus);
  }
  return s;
}

public static Func<RC_eadaf2f9446fb019e39088d303bee2ef, ssConectaProveedores.RestRecords.RESTRC_eadaf2f9446fb019e39088d303bee2ef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eadaf2f9446fb019e39088d303bee2ef s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_eadaf2f9446fb019e39088d303bee2ef FromStructure(RC_eadaf2f9446fb019e39088d303bee2ef s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_eadaf2f9446fb019e39088d303bee2ef(s, config);
}

}


