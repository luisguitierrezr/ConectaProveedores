namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] OcrResult (170tYkvUkUSBzAKEBfEykQ)
///  <code>ST_ce06f43cf108d98e4f79c0106fcfd0acStructure</code> that represents <code>OcrResult</code
/// > <p>Description: </p>
/// </summary>
// Name: OcrResult
public partial struct ST_ce06f43cf108d98e4f79c0106fcfd0acStructure : ITypedRecord<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("k74CdrD9tWY2jZjlGrVZpw*E5I6TeSQI4CoHm+e_rENcw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("k74CdrD9tWY2jZjlGrVZpw*vQBiUC_qMt88z+kewr06qA");
internal static readonly GlobalObjectKey IdExtractedText = GlobalObjectKey.Parse("k74CdrD9tWY2jZjlGrVZpw*StIzNrhgH53GQfTJNownTw");
internal static readonly GlobalObjectKey IdDebugLog = GlobalObjectKey.Parse("k74CdrD9tWY2jZjlGrVZpw*7599a0JFU+O0evMt2q2Byg");

public bool ssSuccess;

public string ssMessage;

public string ssExtractedText;

public string ssDebugLog;


public BitArray OptimizedAttributes;

public ST_ce06f43cf108d98e4f79c0106fcfd0acStructure() {
OptimizedAttributes = null;
ssSuccess = false;
ssMessage = "";
ssExtractedText = "";
ssDebugLog = "";
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
ssSuccess = r.ReadBoolean(index++, "OcrResult.Success", false);
ssMessage = r.ReadText(index++, "OcrResult.Message", "");
ssExtractedText = r.ReadText(index++, "OcrResult.ExtractedText", "");
ssDebugLog = r.ReadText(index++, "OcrResult.DebugLog", "");
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
public void ReadIM(ST_ce06f43cf108d98e4f79c0106fcfd0acStructure r) {
this = r;
}


public static bool operator == (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure a, ST_ce06f43cf108d98e4f79c0106fcfd0acStructure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssExtractedText != b.ssExtractedText) return false;
if (a.ssDebugLog != b.ssDebugLog) return false;
return true;
}

public static bool operator != (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure a, ST_ce06f43cf108d98e4f79c0106fcfd0acStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure)) return false;
return (this == (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssExtractedText.GetHashCode()
 ^ ssDebugLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ce06f43cf108d98e4f79c0106fcfd0acStructure Duplicate() {
ST_ce06f43cf108d98e4f79c0106fcfd0acStructure t;
t.ssSuccess = this.ssSuccess;
t.ssMessage = this.ssMessage;
t.ssExtractedText = this.ssExtractedText;
t.ssDebugLog = this.ssDebugLog;
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
if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Success")) variable.Value = ssSuccess; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "extractedtext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtractedText")) variable.Value = ssExtractedText; else variable.Optimized = true;
} else if (head == "debuglog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DebugLog")) variable.Value = ssDebugLog; else variable.Optimized = true;
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
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdExtractedText) {
return ssExtractedText;
}
if (key == IdDebugLog) {
return ssDebugLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdExtractedText.Key.AsGuid) {
return ssExtractedText;
}
if (attributeKey == IdDebugLog.Key.AsGuid) {
return ssDebugLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssMessage = (string) other.AttributeGet(IdMessage);
ssExtractedText = (string) other.AttributeGet(IdExtractedText);
ssDebugLog = (string) other.AttributeGet(IdDebugLog);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.GetAttribute(IdSuccess.Key.AsGuid);
ssMessage = (string) other.GetAttribute(IdMessage.Key.AsGuid);
ssExtractedText = (string) other.GetAttribute(IdExtractedText.Key.AsGuid);
ssDebugLog = (string) other.GetAttribute(IdDebugLog.Key.AsGuid);
}
} // ST_ce06f43cf108d98e4f79c0106fcfd0acStructure
/// <summary>
/// RecordList type <code>OcrResultList</code> that represents a record list of <code>OcrResult</code>
/// </summary>
public partial class RL_5e97897683d849565850b5fb2acd31b0 : GenericRecordList<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure>, IEnumerable, IEnumerator {

protected override ST_ce06f43cf108d98e4f79c0106fcfd0acStructure GetElementDefaultValue() {
return new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();
}

public T[] ToArray<T>(Func<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5e97897683d849565850b5fb2acd31b0 recordList, Func<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5e97897683d849565850b5fb2acd31b0(ST_ce06f43cf108d98e4f79c0106fcfd0acStructure[] array) {
  RL_5e97897683d849565850b5fb2acd31b0 result = new RL_5e97897683d849565850b5fb2acd31b0();
result.InnerFromArray(array);
    return result;
}

public static RL_5e97897683d849565850b5fb2acd31b0 ToList<T>(T[] array, Func <T, ST_ce06f43cf108d98e4f79c0106fcfd0acStructure> converter) {
  RL_5e97897683d849565850b5fb2acd31b0 result = new RL_5e97897683d849565850b5fb2acd31b0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5e97897683d849565850b5fb2acd31b0 FromRestList<T>(RestList<T> restList, Func <T, ST_ce06f43cf108d98e4f79c0106fcfd0acStructure> converter) {
  RL_5e97897683d849565850b5fb2acd31b0 result = new RL_5e97897683d849565850b5fb2acd31b0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5e97897683d849565850b5fb2acd31b0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure> NewList() {
return new RL_5e97897683d849565850b5fb2acd31b0();
}


} // RL_5e97897683d849565850b5fb2acd31b0
}

