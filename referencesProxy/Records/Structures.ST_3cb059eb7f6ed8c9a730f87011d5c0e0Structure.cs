namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] DropdownItem (HtkRvxJM2Ei2Sybv2lB94A)
///  <code>ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure</code> that represents <code>DropdownItem</code
/// > <p>Description: Strcuture used on DropdownSearch and DropdownTag blocks.</p>
/// </summary>
// Name: DropdownItem
public partial struct ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure : ITypedRecord<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6+CKwB3DW0Kvk0xlIXNtiA");
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MdBsWy7XwUONtPSl55KFlg");

public string ssValue;

public string ssText;


public BitArray OptimizedAttributes;

public ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure() {
OptimizedAttributes = null;
ssValue = "";
ssText = "";
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
ssValue = r.ReadText(index++, "DropdownItem.Value", "");
ssText = r.ReadText(index++, "DropdownItem.Text", "");
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
public void ReadIM(ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure r) {
this = r;
}


public static bool operator == (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure a, ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure b) {
if (a.ssValue != b.ssValue) return false;
if (a.ssText != b.ssText) return false;
return true;
}

public static bool operator != (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure a, ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure)) return false;
return (this == (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssText.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure Duplicate() {
ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure t;
t.ssValue = this.ssValue;
t.ssText = this.ssText;
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
} else if (head == "text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
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
if (key == IdText) {
return ssText;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
if (attributeKey == IdText.Key.AsGuid) {
return ssText;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (string) other.AttributeGet(IdValue);
ssText = (string) other.AttributeGet(IdText);
}
} // ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure
/// <summary>
/// RecordList type <code>DropdownItemList</code> that represents a record list of
///  <code>DropdownItem</code>
/// </summary>
public partial class RL_bb23cfabef259372d4ccc6deba43b63b : GenericRecordList<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure>, IEnumerable, IEnumerator {

protected override ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure GetElementDefaultValue() {
return new ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure();
}

public T[] ToArray<T>(Func<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb23cfabef259372d4ccc6deba43b63b recordList, Func<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb23cfabef259372d4ccc6deba43b63b(ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure[] array) {
  RL_bb23cfabef259372d4ccc6deba43b63b result = new RL_bb23cfabef259372d4ccc6deba43b63b();
result.InnerFromArray(array);
    return result;
}

public static RL_bb23cfabef259372d4ccc6deba43b63b ToList<T>(T[] array, Func <T, ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> converter) {
  RL_bb23cfabef259372d4ccc6deba43b63b result = new RL_bb23cfabef259372d4ccc6deba43b63b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb23cfabef259372d4ccc6deba43b63b FromRestList<T>(RestList<T> restList, Func <T, ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> converter) {
  RL_bb23cfabef259372d4ccc6deba43b63b result = new RL_bb23cfabef259372d4ccc6deba43b63b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb23cfabef259372d4ccc6deba43b63b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> NewList() {
return new RL_bb23cfabef259372d4ccc6deba43b63b();
}


} // RL_bb23cfabef259372d4ccc6deba43b63b
}

