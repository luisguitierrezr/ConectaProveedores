namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TextLiteral (PiKz7h8yL0S5byoV47W_5w) <code>STTextLiteralStructure</code> that
///  represents <code>TextLiteral</code> <p>Description: Represents a text value. Used as a recor
/// d definition when providing a list of TextLiteral records to include in a SQL IN clause.</p>
/// </summary>
// Name: TextLiteral
public partial struct STTextLiteralStructure : ITypedRecord<STTextLiteralStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("RpZuw68MEEWtNSiouXwouA*WcH9J3968Um_yf0pQ4vmFw");

public string ssValue;


public BitArray OptimizedAttributes;

public STTextLiteralStructure() {
OptimizedAttributes = null;
ssValue = "";
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
ssValue = r.ReadText(index++, "TextLiteral.Value", "");
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
public void ReadIM(STTextLiteralStructure r) {
this = r;
}


public static bool operator == (STTextLiteralStructure a, STTextLiteralStructure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (STTextLiteralStructure a, STTextLiteralStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STTextLiteralStructure)) return false;
return (this == (STTextLiteralStructure)o);
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


public STTextLiteralStructure Duplicate() {
STTextLiteralStructure t;
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
ssValue = (string) other.AttributeGet(IdValue);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssValue = (string) other.GetAttribute(IdValue.Key.AsGuid);
}
} // STTextLiteralStructure
/// <summary>
/// RecordList type <code>TextLiteralList</code> that represents a record list of
///  <code>TextLiteral</code>
/// </summary>
public partial class RLTextLiteralList : GenericRecordList<STTextLiteralStructure>, IEnumerable, IEnumerator {

protected override STTextLiteralStructure GetElementDefaultValue() {
return new STTextLiteralStructure();
}

public T[] ToArray<T>(Func<STTextLiteralStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLTextLiteralList recordList, Func<STTextLiteralStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLTextLiteralList(STTextLiteralStructure[] array) {
  RLTextLiteralList result = new RLTextLiteralList();
result.InnerFromArray(array);
    return result;
}

public static RLTextLiteralList ToList<T>(T[] array, Func <T, STTextLiteralStructure> converter) {
  RLTextLiteralList result = new RLTextLiteralList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLTextLiteralList FromRestList<T>(RestList<T> restList, Func <T, STTextLiteralStructure> converter) {
  RLTextLiteralList result = new RLTextLiteralList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLTextLiteralList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STTextLiteralStructure> NewList() {
return new RLTextLiteralList();
}


} // RLTextLiteralList
}

