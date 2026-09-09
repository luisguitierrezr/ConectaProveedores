namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] Text2 (4rSXqWCNxkekV3WCTCA29w) <code>STTextStructure</code> that represents
///  <code>Text2</code> <p>Description: Represents a single Text attribute.</p>
/// </summary>
// Name: Text2
public partial struct STTextStructure : ITypedRecord<STTextStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("d6CatvSs3Eu81Z3vgdfdzQ*+TDTYw6kyLici78NoFRKPQ");

public string ssValue;


public BitArray OptimizedAttributes;

public STTextStructure() {
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
ssValue = r.ReadText(index++, "Text2.Value", "");
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
public void ReadIM(STTextStructure r) {
this = r;
}


public static bool operator == (STTextStructure a, STTextStructure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (STTextStructure a, STTextStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STTextStructure)) return false;
return (this == (STTextStructure)o);
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


public STTextStructure Duplicate() {
STTextStructure t;
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
} // STTextStructure
/// <summary>
/// RecordList type <code>Text2List</code> that represents a record list of <code>Text2</code>
/// </summary>
public partial class RLTextList : GenericRecordList<STTextStructure>, IEnumerable, IEnumerator {

protected override STTextStructure GetElementDefaultValue() {
return new STTextStructure();
}

public T[] ToArray<T>(Func<STTextStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLTextList recordList, Func<STTextStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLTextList(STTextStructure[] array) {
  RLTextList result = new RLTextList();
result.InnerFromArray(array);
    return result;
}

public static RLTextList ToList<T>(T[] array, Func <T, STTextStructure> converter) {
  RLTextList result = new RLTextList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLTextList FromRestList<T>(RestList<T> restList, Func <T, STTextStructure> converter) {
  RLTextList result = new RLTextList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLTextList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STTextStructure> NewList() {
return new RLTextList();
}


} // RLTextList
}

