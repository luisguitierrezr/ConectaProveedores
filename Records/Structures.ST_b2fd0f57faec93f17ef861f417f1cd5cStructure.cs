namespace ssConectaProveedores {
/// <summary>
/// [Structure] MinuteDocumentType (7ETSw6K5mkqvhH0g58XzBQ)
///  <code>ST_b2fd0f57faec93f17ef861f417f1cd5cStructure</code> that represent
/// s <code>MinuteDocumentType</code> <p>Description: </p>
/// </summary>
// Name: MinuteDocumentType
public partial struct ST_b2fd0f57faec93f17ef861f417f1cd5cStructure : ITypedRecord<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure> {
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eTM_SYBrg0CusS6fnZKd0w");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ySj_ubs1akmTrtfe16SUIg");
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Tqts+cbsF0Gpuk6QEk9e5Q");
internal static readonly GlobalObjectKey IdMandatory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jgfAvVKN30mKSlW561y7WQ");
internal static readonly GlobalObjectKey IdWithDocument = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YxR3H8lcaku0urh6J0avMA");

public int ssKey;

public string ssValue;

public string ssFileName;

public bool ssMandatory;

public bool ssWithDocument;


public BitArray OptimizedAttributes;

public ST_b2fd0f57faec93f17ef861f417f1cd5cStructure() {
OptimizedAttributes = null;
ssKey = 0;
ssValue = "";
ssFileName = "";
ssMandatory = false;
ssWithDocument = false;
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
ssKey = r.ReadInteger(index++, "MinuteDocumentType.Key", 0);
ssValue = r.ReadText(index++, "MinuteDocumentType.Value", "");
ssFileName = r.ReadText(index++, "MinuteDocumentType.FileName", "");
ssMandatory = r.ReadBoolean(index++, "MinuteDocumentType.Mandatory", false);
ssWithDocument = r.ReadBoolean(index++, "MinuteDocumentType.WithDocument", false);
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
public void ReadIM(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure r) {
this = r;
}


public static bool operator == (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure a, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure b) {
if (a.ssKey != b.ssKey) return false;
if (a.ssValue != b.ssValue) return false;
if (a.ssFileName != b.ssFileName) return false;
if (a.ssMandatory != b.ssMandatory) return false;
if (a.ssWithDocument != b.ssWithDocument) return false;
return true;
}

public static bool operator != (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure a, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure)) return false;
return (this == (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssMandatory.GetHashCode()
 ^ ssWithDocument.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b2fd0f57faec93f17ef861f417f1cd5cStructure Duplicate() {
ST_b2fd0f57faec93f17ef861f417f1cd5cStructure t;
t.ssKey = this.ssKey;
t.ssValue = this.ssValue;
t.ssFileName = this.ssFileName;
t.ssMandatory = this.ssMandatory;
t.ssWithDocument = this.ssWithDocument;
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
if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
} else if (head == "mandatory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Mandatory")) variable.Value = ssMandatory; else variable.Optimized = true;
} else if (head == "withdocument") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WithDocument")) variable.Value = ssWithDocument; else variable.Optimized = true;
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
if (key == IdKey) {
return ssKey;
}
if (key == IdValue) {
return ssValue;
}
if (key == IdFileName) {
return ssFileName;
}
if (key == IdMandatory) {
return ssMandatory;
}
if (key == IdWithDocument) {
return ssWithDocument;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdMandatory.Key.AsGuid) {
return ssMandatory;
}
if (attributeKey == IdWithDocument.Key.AsGuid) {
return ssWithDocument;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKey = (int) other.AttributeGet(IdKey);
ssValue = (string) other.AttributeGet(IdValue);
ssFileName = (string) other.AttributeGet(IdFileName);
ssMandatory = (bool) other.AttributeGet(IdMandatory);
ssWithDocument = (bool) other.AttributeGet(IdWithDocument);
}
} // ST_b2fd0f57faec93f17ef861f417f1cd5cStructure
/// <summary>
/// RecordList type <code>MinuteDocumentTypeList</code> that represents a record list of
///  <code>MinuteDocumentType</code>
/// </summary>
public partial class RL_f4c5cb6ef02fae333513cbd4dafd500c : GenericRecordList<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure>, IEnumerable, IEnumerator {

protected override ST_b2fd0f57faec93f17ef861f417f1cd5cStructure GetElementDefaultValue() {
return new ST_b2fd0f57faec93f17ef861f417f1cd5cStructure();
}

public T[] ToArray<T>(Func<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f4c5cb6ef02fae333513cbd4dafd500c recordList, Func<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f4c5cb6ef02fae333513cbd4dafd500c(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure[] array) {
  RL_f4c5cb6ef02fae333513cbd4dafd500c result = new RL_f4c5cb6ef02fae333513cbd4dafd500c();
result.InnerFromArray(array);
    return result;
}

public static RL_f4c5cb6ef02fae333513cbd4dafd500c ToList<T>(T[] array, Func <T, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure> converter) {
  RL_f4c5cb6ef02fae333513cbd4dafd500c result = new RL_f4c5cb6ef02fae333513cbd4dafd500c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f4c5cb6ef02fae333513cbd4dafd500c FromRestList<T>(RestList<T> restList, Func <T, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure> converter) {
  RL_f4c5cb6ef02fae333513cbd4dafd500c result = new RL_f4c5cb6ef02fae333513cbd4dafd500c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f4c5cb6ef02fae333513cbd4dafd500c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b2fd0f57faec93f17ef861f417f1cd5cStructure> NewList() {
return new RL_f4c5cb6ef02fae333513cbd4dafd500c();
}


} // RL_f4c5cb6ef02fae333513cbd4dafd500c
}

