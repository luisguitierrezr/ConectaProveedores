namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (hHZitWm1MkaJoTA1bHpjFQ) <code>RCFileRecord</code> that represents
///  <code>File2Record</code> <p>Description: </p>
/// </summary>
// Name: File2Record
public partial struct RCFileRecord : ITypedRecord<RCFileRecord>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yFuQK2LsFAqOVN2uU8sgOQ");

public STFileStructure ssSTFile2;


public static implicit operator STFileStructure( RCFileRecord r) {
return r.ssSTFile2;
}

public static implicit operator RCFileRecord (STFileStructure r) {
RCFileRecord res = new RCFileRecord ();
res.ssSTFile2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RCFileRecord() {
OptimizedAttributes = null;
ssSTFile2 = new STFileStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTFile2.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTFile2.Read( r, ref index);
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
public void ReadIM(RCFileRecord r) {
this = r;
}


public static bool operator == (RCFileRecord a, RCFileRecord b) {
if (a.ssSTFile2 != b.ssSTFile2) return false;
return true;
}

public static bool operator != (RCFileRecord a, RCFileRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCFileRecord)) return false;
return (this == (RCFileRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFile2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFile2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFile2.InternalRecursiveSave();
}


public RCFileRecord Duplicate() {
RCFileRecord t;
t.ssSTFile2 = (STFileStructure)this.ssSTFile2.Duplicate();
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
if (head == "file2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".File2")) variable.Value = ssSTFile2; else variable.Optimized = true;
variable.SetFieldName("file2");
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
if (key == IdFile2) {
return ssSTFile2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFile2.Key.AsGuid) {
return ssSTFile2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFile2.FillFromOther((IRecord) other.AttributeGet(IdFile2));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTFile2.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdFile2.Key.AsGuid));
}
} // RCFileRecord
/// <summary>
/// RecordList type <code>File2RecordList</code> that represents a record list of <code>File2</code>
/// </summary>
public partial class RLFileRecordList : GenericRecordList<RCFileRecord>, IEnumerable, IEnumerator , OutSystems.Application.Extensibility.DataTypes.IRecordList {

public IEnumerable<OutSystems.Application.Extensibility.DataTypes.IRecord> GetRecords() {
    return _data.Cast<OutSystems.Application.Extensibility.DataTypes.IRecord>();
}

public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecordList other) {
    foreach (var element in other.GetRecords()) {
        var convertedElement = new RCFileRecord();
        convertedElement.CopyFrom(element);
        Append(convertedElement);
    }
}


protected override RCFileRecord GetElementDefaultValue() {
return new RCFileRecord();
}

public T[] ToArray<T>(Func<RCFileRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLFileRecordList recordList, Func<RCFileRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLFileRecordList(RCFileRecord[] array) {
  RLFileRecordList result = new RLFileRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLFileRecordList ToList<T>(T[] array, Func <T, RCFileRecord> converter) {
  RLFileRecordList result = new RLFileRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLFileRecordList FromRestList<T>(RestList<T> restList, Func <T, RCFileRecord> converter) {
  RLFileRecordList result = new RLFileRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLFileRecordList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RCFileRecord> NewList() {
return new RLFileRecordList();
}


} // RLFileRecordList
}

