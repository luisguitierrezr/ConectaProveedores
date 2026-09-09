namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rvB9Tt4cmUOn6XRP1kTjvA) <code>RCXmlErrorRecord</code> that represents
///  <code>XmlErrorRecord</code> <p>Description: </p>
/// </summary>
// Name: XmlErrorRecord
public partial struct RCXmlErrorRecord : ITypedRecord<RCXmlErrorRecord>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdXmlError = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bKcBsME6HCHA_52tY61gsQ");

public STXmlErrorStructure ssSTXmlError;


public static implicit operator STXmlErrorStructure( RCXmlErrorRecord r) {
return r.ssSTXmlError;
}

public static implicit operator RCXmlErrorRecord (STXmlErrorStructure r) {
RCXmlErrorRecord res = new RCXmlErrorRecord ();
res.ssSTXmlError = r;
return res;
}

public BitArray OptimizedAttributes;

public RCXmlErrorRecord() {
OptimizedAttributes = null;
ssSTXmlError = new STXmlErrorStructure();
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
    ssSTXmlError.OptimizedAttributes = value[0];
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
ssSTXmlError.Read( r, ref index);
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
public void ReadIM(RCXmlErrorRecord r) {
this = r;
}


public static bool operator == (RCXmlErrorRecord a, RCXmlErrorRecord b) {
if (a.ssSTXmlError != b.ssSTXmlError) return false;
return true;
}

public static bool operator != (RCXmlErrorRecord a, RCXmlErrorRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCXmlErrorRecord)) return false;
return (this == (RCXmlErrorRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTXmlError.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTXmlError.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTXmlError.InternalRecursiveSave();
}


public RCXmlErrorRecord Duplicate() {
RCXmlErrorRecord t;
t.ssSTXmlError = (STXmlErrorStructure)this.ssSTXmlError.Duplicate();
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
if (head == "xmlerror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".XmlError")) variable.Value = ssSTXmlError; else variable.Optimized = true;
variable.SetFieldName("xmlerror");
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
if (key == IdXmlError) {
return ssSTXmlError;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdXmlError.Key.AsGuid) {
return ssSTXmlError;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTXmlError.FillFromOther((IRecord) other.AttributeGet(IdXmlError));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTXmlError.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdXmlError.Key.AsGuid));
}
} // RCXmlErrorRecord
/// <summary>
/// RecordList type <code>XmlErrorRecordList</code> that represents a record list of
///  <code>XmlError</code>
/// </summary>
public partial class RLXmlErrorRecordList : GenericRecordList<RCXmlErrorRecord>, IEnumerable, IEnumerator , OutSystems.Application.Extensibility.DataTypes.IRecordList {

public IEnumerable<OutSystems.Application.Extensibility.DataTypes.IRecord> GetRecords() {
    return _data.Cast<OutSystems.Application.Extensibility.DataTypes.IRecord>();
}

public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecordList other) {
    foreach (var element in other.GetRecords()) {
        var convertedElement = new RCXmlErrorRecord();
        convertedElement.CopyFrom(element);
        Append(convertedElement);
    }
}


protected override RCXmlErrorRecord GetElementDefaultValue() {
return new RCXmlErrorRecord();
}

public T[] ToArray<T>(Func<RCXmlErrorRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLXmlErrorRecordList recordList, Func<RCXmlErrorRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLXmlErrorRecordList(RCXmlErrorRecord[] array) {
  RLXmlErrorRecordList result = new RLXmlErrorRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLXmlErrorRecordList ToList<T>(T[] array, Func <T, RCXmlErrorRecord> converter) {
  RLXmlErrorRecordList result = new RLXmlErrorRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLXmlErrorRecordList FromRestList<T>(RestList<T> restList, Func <T, RCXmlErrorRecord> converter) {
  RLXmlErrorRecordList result = new RLXmlErrorRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLXmlErrorRecordList() : base() {
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
protected override OSList<RCXmlErrorRecord> NewList() {
return new RLXmlErrorRecordList();
}


} // RLXmlErrorRecordList
}

