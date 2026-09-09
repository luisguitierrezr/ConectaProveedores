namespace ssConectaProveedores {
/// <summary>
/// [Structure] MinuteDocumentTypeUpdate (mDKTpQmh9kaiYpgHQt+7sQ)
///  <code>ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure</code> that represent
/// s <code>MinuteDocumentTypeUpdate</code> <p>Description: </p>
/// </summary>
// Name: MinuteDocumentTypeUpdate
public partial struct ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure : ITypedRecord<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> {
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*u8mXIeOxJkWhI+aoOjgH_g");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4tIGq3hV7k+VwKE7RG3QCQ");
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JC9hLMAn2kCevK+kAnw2nQ");
internal static readonly GlobalObjectKey IdMandatory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LvAW96Td+kawH7wdcLeU2Q");
internal static readonly GlobalObjectKey IdWithDocument = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y1UIZf_Ow0SQr7hNeA0zEA");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uY58Nn7ZNUWB8wul1OQCZA");

public int ssKey;

public string ssValue;

public string ssFileName;

public bool ssMandatory;

public bool ssWithDocument;

public long ssStorageId;


public BitArray OptimizedAttributes;

public ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure() {
OptimizedAttributes = null;
ssKey = 0;
ssValue = "";
ssFileName = "";
ssMandatory = false;
ssWithDocument = false;
ssStorageId = 0L;
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
ssKey = r.ReadInteger(index++, "MinuteDocumentTypeUpdate.Key", 0);
ssValue = r.ReadText(index++, "MinuteDocumentTypeUpdate.Value", "");
ssFileName = r.ReadText(index++, "MinuteDocumentTypeUpdate.FileName", "");
ssMandatory = r.ReadBoolean(index++, "MinuteDocumentTypeUpdate.Mandatory", false);
ssWithDocument = r.ReadBoolean(index++, "MinuteDocumentTypeUpdate.WithDocument", false);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "MinuteDocumentTypeUpdate.StorageId", 0L);
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
public void ReadIM(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure r) {
this = r;
}


public static bool operator == (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure a, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure b) {
if (a.ssKey != b.ssKey) return false;
if (a.ssValue != b.ssValue) return false;
if (a.ssFileName != b.ssFileName) return false;
if (a.ssMandatory != b.ssMandatory) return false;
if (a.ssWithDocument != b.ssWithDocument) return false;
if (a.ssStorageId != b.ssStorageId) return false;
return true;
}

public static bool operator != (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure a, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure)) return false;
return (this == (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssMandatory.GetHashCode()
 ^ ssWithDocument.GetHashCode()
 ^ ssStorageId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure Duplicate() {
ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure t;
t.ssKey = this.ssKey;
t.ssValue = this.ssValue;
t.ssFileName = this.ssFileName;
t.ssMandatory = this.ssMandatory;
t.ssWithDocument = this.ssWithDocument;
t.ssStorageId = this.ssStorageId;
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
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
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
if (key == IdStorageId) {
return ssStorageId;
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
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
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
ssStorageId = (long) other.AttributeGet(IdStorageId);
}
} // ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure
/// <summary>
/// RecordList type <code>MinuteDocumentTypeUpdateList</code> that represents a record list of
///  <code>MinuteDocumentTypeUpdate</code>
/// </summary>
public partial class RL_9fb5c5e988576f6c521a9ef779213183 : GenericRecordList<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure>, IEnumerable, IEnumerator {

protected override ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure GetElementDefaultValue() {
return new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure();
}

public T[] ToArray<T>(Func<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9fb5c5e988576f6c521a9ef779213183 recordList, Func<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9fb5c5e988576f6c521a9ef779213183(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure[] array) {
  RL_9fb5c5e988576f6c521a9ef779213183 result = new RL_9fb5c5e988576f6c521a9ef779213183();
result.InnerFromArray(array);
    return result;
}

public static RL_9fb5c5e988576f6c521a9ef779213183 ToList<T>(T[] array, Func <T, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> converter) {
  RL_9fb5c5e988576f6c521a9ef779213183 result = new RL_9fb5c5e988576f6c521a9ef779213183();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9fb5c5e988576f6c521a9ef779213183 FromRestList<T>(RestList<T> restList, Func <T, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> converter) {
  RL_9fb5c5e988576f6c521a9ef779213183 result = new RL_9fb5c5e988576f6c521a9ef779213183();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9fb5c5e988576f6c521a9ef779213183() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> NewList() {
return new RL_9fb5c5e988576f6c521a9ef779213183();
}


} // RL_9fb5c5e988576f6c521a9ef779213183
}

