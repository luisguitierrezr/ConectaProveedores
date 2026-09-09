namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] OnPremisesExtensionAttribute (x6+1lGn4yUqT2EnGrvmtZQ)
///  <code>ST_f5088e93197e1d0bc0e83e9a247c44fbStructure</code> that represent
/// s <code>OnPremisesExtensionAttribute</code> <p>Description: </p>
/// </summary>
// Name: OnPremisesExtensionAttribute
public partial struct ST_f5088e93197e1d0bc0e83e9a247c44fbStructure : ITypedRecord<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> {
internal static readonly GlobalObjectKey IdExtensionAttribute1 = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*FmAtfZviZ0qFCpZZzRPh7Q");

public string ssExtensionAttribute1;


public BitArray OptimizedAttributes;

public ST_f5088e93197e1d0bc0e83e9a247c44fbStructure() {
OptimizedAttributes = null;
ssExtensionAttribute1 = "";
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
ssExtensionAttribute1 = r.ReadText(index++, "OnPremisesExtensionAttribute.ExtensionAttribute1", "");
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
public void ReadIM(ST_f5088e93197e1d0bc0e83e9a247c44fbStructure r) {
this = r;
}


public static bool operator == (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure a, ST_f5088e93197e1d0bc0e83e9a247c44fbStructure b) {
if (a.ssExtensionAttribute1 != b.ssExtensionAttribute1) return false;
return true;
}

public static bool operator != (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure a, ST_f5088e93197e1d0bc0e83e9a247c44fbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure)) return false;
return (this == (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssExtensionAttribute1.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f5088e93197e1d0bc0e83e9a247c44fbStructure Duplicate() {
ST_f5088e93197e1d0bc0e83e9a247c44fbStructure t;
t.ssExtensionAttribute1 = this.ssExtensionAttribute1;
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
if (head == "extensionattribute1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtensionAttribute1")) variable.Value = ssExtensionAttribute1; else variable.Optimized = true;
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
if (key == IdExtensionAttribute1) {
return ssExtensionAttribute1;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExtensionAttribute1.Key.AsGuid) {
return ssExtensionAttribute1;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssExtensionAttribute1 = (string) other.AttributeGet(IdExtensionAttribute1);
}
} // ST_f5088e93197e1d0bc0e83e9a247c44fbStructure
/// <summary>
/// RecordList type <code>OnPremisesExtensionAttributeList</code> that represents a record list of
///  <code>OnPremisesExtensionAttribute</code>
/// </summary>
public partial class RL_7910768a4f6ca2676225cc41009d5c36 : GenericRecordList<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure>, IEnumerable, IEnumerator {

protected override ST_f5088e93197e1d0bc0e83e9a247c44fbStructure GetElementDefaultValue() {
return new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure();
}

public T[] ToArray<T>(Func<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7910768a4f6ca2676225cc41009d5c36 recordList, Func<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7910768a4f6ca2676225cc41009d5c36(ST_f5088e93197e1d0bc0e83e9a247c44fbStructure[] array) {
  RL_7910768a4f6ca2676225cc41009d5c36 result = new RL_7910768a4f6ca2676225cc41009d5c36();
result.InnerFromArray(array);
    return result;
}

public static RL_7910768a4f6ca2676225cc41009d5c36 ToList<T>(T[] array, Func <T, ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> converter) {
  RL_7910768a4f6ca2676225cc41009d5c36 result = new RL_7910768a4f6ca2676225cc41009d5c36();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7910768a4f6ca2676225cc41009d5c36 FromRestList<T>(RestList<T> restList, Func <T, ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> converter) {
  RL_7910768a4f6ca2676225cc41009d5c36 result = new RL_7910768a4f6ca2676225cc41009d5c36();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7910768a4f6ca2676225cc41009d5c36() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> NewList() {
return new RL_7910768a4f6ca2676225cc41009d5c36();
}


} // RL_7910768a4f6ca2676225cc41009d5c36
}

