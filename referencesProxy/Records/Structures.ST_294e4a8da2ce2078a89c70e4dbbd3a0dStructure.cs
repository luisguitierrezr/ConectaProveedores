namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] AuditPublicStruc (zGvxyQnUFkyz9TO5YNjlYA)
///  <code>ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure</code> that represent
/// s <code>AuditPublicStruc</code> <p>Description: Audit Public Struc</p>
/// </summary>
// Name: AuditPublicStruc
public partial struct ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure : ITypedRecord<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*f3thUm+sKU2gaHLL3KdZiA");
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*_eNAHq0Wt0SS5olQoPas_Q");
internal static readonly GlobalObjectKey IdIdentifier = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*C2GJgqzlaUmVz0Fpl2sJ8Q");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*nr6vJWXWxkaL3PDaFrbZyw");
internal static readonly GlobalObjectKey IdScreen = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*AG3j1pHx402SFMlMnqO5oQ");
internal static readonly GlobalObjectKey IdFunctionality = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*rRR53kAwO0C+NKkeEmNDMA");
internal static readonly GlobalObjectKey IdOriginalJSON = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*ZazR9ovd2EqWjSMaNZQPEQ");
internal static readonly GlobalObjectKey IdChangeJSON = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*QsFjJ0Y35E22RTCawo7h3A");
internal static readonly GlobalObjectKey IdOccurrenceRoleName = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*VZqfqAmufEeFTIfXaSCSKg");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*jtVY+DiirUuVwhcua8g9Bw");

public long ssId;

public int ssOrigin;

public long ssIdentifier;

public string ssMessage;

public string ssScreen;

public string ssFunctionality;

public string ssOriginalJSON;

public string ssChangeJSON;

public string ssOccurrenceRoleName;

public bool ssIsError;


public BitArray OptimizedAttributes;

public ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure() {
OptimizedAttributes = null;
ssId = 0L;
ssOrigin = 0;
ssIdentifier = 0L;
ssMessage = "";
ssScreen = "";
ssFunctionality = "";
ssOriginalJSON = "";
ssChangeJSON = "";
ssOccurrenceRoleName = "";
ssIsError = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadLongInteger(index++, "AuditPublicStruc.Id", 0L);
ssOrigin = r.ReadEntityReference(index++, "AuditPublicStruc.Origin", 0);
ssIdentifier = r.ReadLongInteger(index++, "AuditPublicStruc.Identifier", 0L);
ssMessage = r.ReadText(index++, "AuditPublicStruc.Message", "");
ssScreen = r.ReadText(index++, "AuditPublicStruc.Screen", "");
ssFunctionality = r.ReadText(index++, "AuditPublicStruc.Functionality", "");
ssOriginalJSON = r.ReadText(index++, "AuditPublicStruc.OriginalJSON", "");
ssChangeJSON = r.ReadText(index++, "AuditPublicStruc.ChangeJSON", "");
ssOccurrenceRoleName = r.ReadText(index++, "AuditPublicStruc.OccurrenceRoleName", "");
ssIsError = r.ReadBoolean(index++, "AuditPublicStruc.IsError", false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure r) {
this = r;
}


public static bool operator == (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure a, ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrigin != b.ssOrigin) return false;
if (a.ssIdentifier != b.ssIdentifier) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssScreen != b.ssScreen) return false;
if (a.ssFunctionality != b.ssFunctionality) return false;
if (a.ssOriginalJSON != b.ssOriginalJSON) return false;
if (a.ssChangeJSON != b.ssChangeJSON) return false;
if (a.ssOccurrenceRoleName != b.ssOccurrenceRoleName) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure a, ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure)) return false;
return (this == (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrigin.GetHashCode()
 ^ ssIdentifier.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssScreen.GetHashCode()
 ^ ssFunctionality.GetHashCode()
 ^ ssOriginalJSON.GetHashCode()
 ^ ssChangeJSON.GetHashCode()
 ^ ssOccurrenceRoleName.GetHashCode()
 ^ ssIsError.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure Duplicate() {
ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure t;
t.ssId = this.ssId;
t.ssOrigin = this.ssOrigin;
t.ssIdentifier = this.ssIdentifier;
t.ssMessage = this.ssMessage;
t.ssScreen = this.ssScreen;
t.ssFunctionality = this.ssFunctionality;
t.ssOriginalJSON = this.ssOriginalJSON;
t.ssChangeJSON = this.ssChangeJSON;
t.ssOccurrenceRoleName = this.ssOccurrenceRoleName;
t.ssIsError = this.ssIsError;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssOrigin; else variable.Optimized = true;
} else if (head == "identifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Identifier")) variable.Value = ssIdentifier; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "screen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Screen")) variable.Value = ssScreen; else variable.Optimized = true;
} else if (head == "functionality") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Functionality")) variable.Value = ssFunctionality; else variable.Optimized = true;
} else if (head == "originaljson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OriginalJSON")) variable.Value = ssOriginalJSON; else variable.Optimized = true;
} else if (head == "changejson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangeJSON")) variable.Value = ssChangeJSON; else variable.Optimized = true;
} else if (head == "occurrencerolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OccurrenceRoleName")) variable.Value = ssOccurrenceRoleName; else variable.Optimized = true;
} else if (head == "iserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrigin) {
return ssOrigin;
}
if (key == IdIdentifier) {
return ssIdentifier;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdScreen) {
return ssScreen;
}
if (key == IdFunctionality) {
return ssFunctionality;
}
if (key == IdOriginalJSON) {
return ssOriginalJSON;
}
if (key == IdChangeJSON) {
return ssChangeJSON;
}
if (key == IdOccurrenceRoleName) {
return ssOccurrenceRoleName;
}
if (key == IdIsError) {
return ssIsError;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssOrigin;
}
if (attributeKey == IdIdentifier.Key.AsGuid) {
return ssIdentifier;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdScreen.Key.AsGuid) {
return ssScreen;
}
if (attributeKey == IdFunctionality.Key.AsGuid) {
return ssFunctionality;
}
if (attributeKey == IdOriginalJSON.Key.AsGuid) {
return ssOriginalJSON;
}
if (attributeKey == IdChangeJSON.Key.AsGuid) {
return ssChangeJSON;
}
if (attributeKey == IdOccurrenceRoleName.Key.AsGuid) {
return ssOccurrenceRoleName;
}
if (attributeKey == IdIsError.Key.AsGuid) {
return ssIsError;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ssOrigin = (int) other.AttributeGet(IdOrigin);
ssIdentifier = (long) other.AttributeGet(IdIdentifier);
ssMessage = (string) other.AttributeGet(IdMessage);
ssScreen = (string) other.AttributeGet(IdScreen);
ssFunctionality = (string) other.AttributeGet(IdFunctionality);
ssOriginalJSON = (string) other.AttributeGet(IdOriginalJSON);
ssChangeJSON = (string) other.AttributeGet(IdChangeJSON);
ssOccurrenceRoleName = (string) other.AttributeGet(IdOccurrenceRoleName);
ssIsError = (bool) other.AttributeGet(IdIsError);
}
} // ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure
/// <summary>
/// RecordList type <code>AuditPublicStrucList</code> that represents a record list of
///  <code>AuditPublicStruc</code>
/// </summary>
public partial class RL_2886d21e57ee0cb356d44ef31b302fbe : GenericRecordList<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure>, IEnumerable, IEnumerator {

protected override ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure GetElementDefaultValue() {
return new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
}

public T[] ToArray<T>(Func<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2886d21e57ee0cb356d44ef31b302fbe recordList, Func<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2886d21e57ee0cb356d44ef31b302fbe(ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure[] array) {
  RL_2886d21e57ee0cb356d44ef31b302fbe result = new RL_2886d21e57ee0cb356d44ef31b302fbe();
result.InnerFromArray(array);
    return result;
}

public static RL_2886d21e57ee0cb356d44ef31b302fbe ToList<T>(T[] array, Func <T, ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> converter) {
  RL_2886d21e57ee0cb356d44ef31b302fbe result = new RL_2886d21e57ee0cb356d44ef31b302fbe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2886d21e57ee0cb356d44ef31b302fbe FromRestList<T>(RestList<T> restList, Func <T, ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> converter) {
  RL_2886d21e57ee0cb356d44ef31b302fbe result = new RL_2886d21e57ee0cb356d44ef31b302fbe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2886d21e57ee0cb356d44ef31b302fbe() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> NewList() {
return new RL_2886d21e57ee0cb356d44ef31b302fbe();
}


} // RL_2886d21e57ee0cb356d44ef31b302fbe
}

