namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0rSXBrww1kKxhQp1rOGqRA) <code>RCTextRecord</code> that represents
///  <code>Text2Record</code> <p>Description: </p>
/// </summary>
// Name: Text2Record
public partial struct RCTextRecord : ITypedRecord<RCTextRecord>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdText2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nrWEDYn_xIdxrrSd+p8sOQ");

public STTextStructure ssSTText2;


public static implicit operator STTextStructure( RCTextRecord r) {
return r.ssSTText2;
}

public static implicit operator RCTextRecord (STTextStructure r) {
RCTextRecord res = new RCTextRecord ();
res.ssSTText2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RCTextRecord() {
OptimizedAttributes = null;
ssSTText2 = new STTextStructure();
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
    ssSTText2.OptimizedAttributes = value[0];
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
ssSTText2.Read( r, ref index);
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
public void ReadIM(RCTextRecord r) {
this = r;
}


public static bool operator == (RCTextRecord a, RCTextRecord b) {
if (a.ssSTText2 != b.ssSTText2) return false;
return true;
}

public static bool operator != (RCTextRecord a, RCTextRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCTextRecord)) return false;
return (this == (RCTextRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTText2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTText2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTText2.InternalRecursiveSave();
}


public RCTextRecord Duplicate() {
RCTextRecord t;
t.ssSTText2 = (STTextStructure)this.ssSTText2.Duplicate();
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
if (head == "text2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text2")) variable.Value = ssSTText2; else variable.Optimized = true;
variable.SetFieldName("text2");
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
if (key == IdText2) {
return ssSTText2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdText2.Key.AsGuid) {
return ssSTText2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTText2.FillFromOther((IRecord) other.AttributeGet(IdText2));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTText2.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdText2.Key.AsGuid));
}
} // RCTextRecord
/// <summary>
/// RecordList type <code>Text2RecordList</code> that represents a record list of <code>Text2</code>
/// </summary>
public partial class RLTextRecordList : GenericRecordList<RCTextRecord>, IEnumerable, IEnumerator , OutSystems.Application.Extensibility.DataTypes.IRecordList {

public IEnumerable<OutSystems.Application.Extensibility.DataTypes.IRecord> GetRecords() {
    return _data.Cast<OutSystems.Application.Extensibility.DataTypes.IRecord>();
}

public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecordList other) {
    foreach (var element in other.GetRecords()) {
        var convertedElement = new RCTextRecord();
        convertedElement.CopyFrom(element);
        Append(convertedElement);
    }
}


protected override RCTextRecord GetElementDefaultValue() {
return new RCTextRecord();
}

public T[] ToArray<T>(Func<RCTextRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLTextRecordList recordList, Func<RCTextRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLTextRecordList(RCTextRecord[] array) {
  RLTextRecordList result = new RLTextRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLTextRecordList ToList<T>(T[] array, Func <T, RCTextRecord> converter) {
  RLTextRecordList result = new RLTextRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLTextRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTextRecord> converter) {
  RLTextRecordList result = new RLTextRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLTextRecordList() : base() {
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
protected override OSList<RCTextRecord> NewList() {
return new RLTextRecordList();
}


} // RLTextRecordList
}

