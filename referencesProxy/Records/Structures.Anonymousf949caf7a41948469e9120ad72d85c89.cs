namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (98pJ+RmkRkiekSCtcthciQ) <code>RCIntegerLiteralRecord</code> that
///  represents <code>IntegerLiteralRecord</code> <p>Description: </p>
/// </summary>
// Name: IntegerLiteralRecord
public partial struct RCIntegerLiteralRecord : ITypedRecord<RCIntegerLiteralRecord>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdIntegerLiteral = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vCMfUHVt4A+3azv6okb2rg");

public STIntegerLiteralStructure ssSTIntegerLiteral;


public static implicit operator STIntegerLiteralStructure( RCIntegerLiteralRecord r) {
return r.ssSTIntegerLiteral;
}

public static implicit operator RCIntegerLiteralRecord (STIntegerLiteralStructure r) {
RCIntegerLiteralRecord res = new RCIntegerLiteralRecord ();
res.ssSTIntegerLiteral = r;
return res;
}

public BitArray OptimizedAttributes;

public RCIntegerLiteralRecord() {
OptimizedAttributes = null;
ssSTIntegerLiteral = new STIntegerLiteralStructure();
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
    ssSTIntegerLiteral.OptimizedAttributes = value[0];
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
ssSTIntegerLiteral.Read( r, ref index);
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
public void ReadIM(RCIntegerLiteralRecord r) {
this = r;
}


public static bool operator == (RCIntegerLiteralRecord a, RCIntegerLiteralRecord b) {
if (a.ssSTIntegerLiteral != b.ssSTIntegerLiteral) return false;
return true;
}

public static bool operator != (RCIntegerLiteralRecord a, RCIntegerLiteralRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCIntegerLiteralRecord)) return false;
return (this == (RCIntegerLiteralRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTIntegerLiteral.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTIntegerLiteral.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTIntegerLiteral.InternalRecursiveSave();
}


public RCIntegerLiteralRecord Duplicate() {
RCIntegerLiteralRecord t;
t.ssSTIntegerLiteral = (STIntegerLiteralStructure)this.ssSTIntegerLiteral.Duplicate();
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
if (head == "integerliteral") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IntegerLiteral")) variable.Value = ssSTIntegerLiteral; else variable.Optimized = true;
variable.SetFieldName("integerliteral");
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
if (key == IdIntegerLiteral) {
return ssSTIntegerLiteral;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIntegerLiteral.Key.AsGuid) {
return ssSTIntegerLiteral;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTIntegerLiteral.FillFromOther((IRecord) other.AttributeGet(IdIntegerLiteral));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTIntegerLiteral.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdIntegerLiteral.Key.AsGuid));
}
} // RCIntegerLiteralRecord
/// <summary>
/// RecordList type <code>IntegerLiteralRecordList</code> that represents a record list of
///  <code>IntegerLiteral</code>
/// </summary>
public partial class RLIntegerLiteralRecordList : GenericRecordList<RCIntegerLiteralRecord>, IEnumerable, IEnumerator {

protected override RCIntegerLiteralRecord GetElementDefaultValue() {
return new RCIntegerLiteralRecord();
}

public T[] ToArray<T>(Func<RCIntegerLiteralRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLIntegerLiteralRecordList recordList, Func<RCIntegerLiteralRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLIntegerLiteralRecordList(RCIntegerLiteralRecord[] array) {
  RLIntegerLiteralRecordList result = new RLIntegerLiteralRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLIntegerLiteralRecordList ToList<T>(T[] array, Func <T, RCIntegerLiteralRecord> converter) {
  RLIntegerLiteralRecordList result = new RLIntegerLiteralRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLIntegerLiteralRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIntegerLiteralRecord> converter) {
  RLIntegerLiteralRecordList result = new RLIntegerLiteralRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLIntegerLiteralRecordList() : base() {
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
protected override OSList<RCIntegerLiteralRecord> NewList() {
return new RLIntegerLiteralRecordList();
}


} // RLIntegerLiteralRecordList
}

