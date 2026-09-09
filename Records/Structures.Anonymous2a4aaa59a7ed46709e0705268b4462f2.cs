namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (WapKKu2ncEaeBwUmi0Ri8g) <code>RCTextLiteralRecord</code> that
///  represents <code>TextLiteralRecord</code> <p>Description: </p>
/// </summary>
// Name: TextLiteralRecord
public partial struct RCTextLiteralRecord : ITypedRecord<RCTextLiteralRecord>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdTextLiteral = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PRbiKUUjfNppYHoSbNRzaQ");

public STTextLiteralStructure ssSTTextLiteral;


public static implicit operator STTextLiteralStructure( RCTextLiteralRecord r) {
return r.ssSTTextLiteral;
}

public static implicit operator RCTextLiteralRecord (STTextLiteralStructure r) {
RCTextLiteralRecord res = new RCTextLiteralRecord ();
res.ssSTTextLiteral = r;
return res;
}

public BitArray OptimizedAttributes;

public RCTextLiteralRecord() {
OptimizedAttributes = null;
ssSTTextLiteral = new STTextLiteralStructure();
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
    ssSTTextLiteral.OptimizedAttributes = value[0];
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
ssSTTextLiteral.Read( r, ref index);
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
public void ReadIM(RCTextLiteralRecord r) {
this = r;
}


public static bool operator == (RCTextLiteralRecord a, RCTextLiteralRecord b) {
if (a.ssSTTextLiteral != b.ssSTTextLiteral) return false;
return true;
}

public static bool operator != (RCTextLiteralRecord a, RCTextLiteralRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCTextLiteralRecord)) return false;
return (this == (RCTextLiteralRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTextLiteral.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTextLiteral.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTextLiteral.InternalRecursiveSave();
}


public RCTextLiteralRecord Duplicate() {
RCTextLiteralRecord t;
t.ssSTTextLiteral = (STTextLiteralStructure)this.ssSTTextLiteral.Duplicate();
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
if (head == "textliteral") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TextLiteral")) variable.Value = ssSTTextLiteral; else variable.Optimized = true;
variable.SetFieldName("textliteral");
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
if (key == IdTextLiteral) {
return ssSTTextLiteral;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTextLiteral.Key.AsGuid) {
return ssSTTextLiteral;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTextLiteral.FillFromOther((IRecord) other.AttributeGet(IdTextLiteral));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTTextLiteral.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdTextLiteral.Key.AsGuid));
}
} // RCTextLiteralRecord
/// <summary>
/// RecordList type <code>TextLiteralRecordList</code> that represents a record list of
///  <code>TextLiteral</code>
/// </summary>
public partial class RLTextLiteralRecordList : GenericRecordList<RCTextLiteralRecord>, IEnumerable, IEnumerator , OutSystems.Application.Extensibility.DataTypes.IRecordList {

public IEnumerable<OutSystems.Application.Extensibility.DataTypes.IRecord> GetRecords() {
    return _data.Cast<OutSystems.Application.Extensibility.DataTypes.IRecord>();
}

public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecordList other) {
    foreach (var element in other.GetRecords()) {
        var convertedElement = new RCTextLiteralRecord();
        convertedElement.CopyFrom(element);
        Append(convertedElement);
    }
}


protected override RCTextLiteralRecord GetElementDefaultValue() {
return new RCTextLiteralRecord();
}

public T[] ToArray<T>(Func<RCTextLiteralRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLTextLiteralRecordList recordList, Func<RCTextLiteralRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLTextLiteralRecordList(RCTextLiteralRecord[] array) {
  RLTextLiteralRecordList result = new RLTextLiteralRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLTextLiteralRecordList ToList<T>(T[] array, Func <T, RCTextLiteralRecord> converter) {
  RLTextLiteralRecordList result = new RLTextLiteralRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLTextLiteralRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTextLiteralRecord> converter) {
  RLTextLiteralRecordList result = new RLTextLiteralRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLTextLiteralRecordList() : base() {
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
protected override OSList<RCTextLiteralRecord> NewList() {
return new RLTextLiteralRecordList();
}


} // RLTextLiteralRecordList
}

