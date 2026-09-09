namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] IntegerLiteral (MhSwmrdYOE6tZeneczvE2A) <code>STIntegerLiteralStructure</code>
///  that represents <code>IntegerLiteral</code> <p>Description: Represents a long integer value. Use
/// d as a record definition when providing a list of IntegerLiteral records to include in a SQL IN
///  clause.</p>
/// </summary>
// Name: IntegerLiteral
public partial struct STIntegerLiteralStructure : ITypedRecord<STIntegerLiteralStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("RpZuw68MEEWtNSiouXwouA*eZ0XPSTXKkatgE5aJlMHxg");

public long ssValue;


public BitArray OptimizedAttributes;

public STIntegerLiteralStructure() {
OptimizedAttributes = null;
ssValue = 0L;
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
ssValue = r.ReadLongInteger(index++, "IntegerLiteral.Value", 0L);
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
public void ReadIM(STIntegerLiteralStructure r) {
this = r;
}


public static bool operator == (STIntegerLiteralStructure a, STIntegerLiteralStructure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (STIntegerLiteralStructure a, STIntegerLiteralStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STIntegerLiteralStructure)) return false;
return (this == (STIntegerLiteralStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public STIntegerLiteralStructure Duplicate() {
STIntegerLiteralStructure t;
t.ssValue = this.ssValue;
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
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (long) other.AttributeGet(IdValue);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssValue = (long) other.GetAttribute(IdValue.Key.AsGuid);
}
} // STIntegerLiteralStructure
/// <summary>
/// RecordList type <code>IntegerLiteralList</code> that represents a record list of
///  <code>IntegerLiteral</code>
/// </summary>
public partial class RLIntegerLiteralList : GenericRecordList<STIntegerLiteralStructure>, IEnumerable, IEnumerator {

protected override STIntegerLiteralStructure GetElementDefaultValue() {
return new STIntegerLiteralStructure();
}

public T[] ToArray<T>(Func<STIntegerLiteralStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLIntegerLiteralList recordList, Func<STIntegerLiteralStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLIntegerLiteralList(STIntegerLiteralStructure[] array) {
  RLIntegerLiteralList result = new RLIntegerLiteralList();
result.InnerFromArray(array);
    return result;
}

public static RLIntegerLiteralList ToList<T>(T[] array, Func <T, STIntegerLiteralStructure> converter) {
  RLIntegerLiteralList result = new RLIntegerLiteralList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLIntegerLiteralList FromRestList<T>(RestList<T> restList, Func <T, STIntegerLiteralStructure> converter) {
  RLIntegerLiteralList result = new RLIntegerLiteralList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLIntegerLiteralList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STIntegerLiteralStructure> NewList() {
return new RLIntegerLiteralList();
}


} // RLIntegerLiteralList
}

