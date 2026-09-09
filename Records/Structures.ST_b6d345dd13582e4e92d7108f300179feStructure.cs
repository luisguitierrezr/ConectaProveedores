namespace ssConectaProveedores {
/// <summary>
/// [Structure] Boolean (nJDa0N6BYk69J2lTCFwWOQ)
///  <code>ST_b6d345dd13582e4e92d7108f300179feStructure</code> that represents <code>Boolean</code
/// > <p>Description: Boolean Value Struct.</p>
/// </summary>
// Name: Boolean
public partial struct ST_b6d345dd13582e4e92d7108f300179feStructure : ITypedRecord<ST_b6d345dd13582e4e92d7108f300179feStructure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QIAM2UEns0GgGS18DcwJvQ");

public bool ssValue;


public BitArray OptimizedAttributes;

public ST_b6d345dd13582e4e92d7108f300179feStructure() {
OptimizedAttributes = null;
ssValue = false;
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
ssValue = r.ReadBoolean(index++, "Boolean.Value", false);
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
public void ReadIM(ST_b6d345dd13582e4e92d7108f300179feStructure r) {
this = r;
}


public static bool operator == (ST_b6d345dd13582e4e92d7108f300179feStructure a, ST_b6d345dd13582e4e92d7108f300179feStructure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_b6d345dd13582e4e92d7108f300179feStructure a, ST_b6d345dd13582e4e92d7108f300179feStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b6d345dd13582e4e92d7108f300179feStructure)) return false;
return (this == (ST_b6d345dd13582e4e92d7108f300179feStructure)o);
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


public ST_b6d345dd13582e4e92d7108f300179feStructure Duplicate() {
ST_b6d345dd13582e4e92d7108f300179feStructure t;
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
ssValue = (bool) other.AttributeGet(IdValue);
}
} // ST_b6d345dd13582e4e92d7108f300179feStructure
/// <summary>
/// RecordList type <code>BooleanList</code> that represents a record list of <code>Boolean</code>
/// </summary>
public partial class RL_969b4cd5a4260a685fb6fcf4e3b82dfe : GenericRecordList<ST_b6d345dd13582e4e92d7108f300179feStructure>, IEnumerable, IEnumerator {

protected override ST_b6d345dd13582e4e92d7108f300179feStructure GetElementDefaultValue() {
return new ST_b6d345dd13582e4e92d7108f300179feStructure();
}

public T[] ToArray<T>(Func<ST_b6d345dd13582e4e92d7108f300179feStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_969b4cd5a4260a685fb6fcf4e3b82dfe recordList, Func<ST_b6d345dd13582e4e92d7108f300179feStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_969b4cd5a4260a685fb6fcf4e3b82dfe(ST_b6d345dd13582e4e92d7108f300179feStructure[] array) {
  RL_969b4cd5a4260a685fb6fcf4e3b82dfe result = new RL_969b4cd5a4260a685fb6fcf4e3b82dfe();
result.InnerFromArray(array);
    return result;
}

public static RL_969b4cd5a4260a685fb6fcf4e3b82dfe ToList<T>(T[] array, Func <T, ST_b6d345dd13582e4e92d7108f300179feStructure> converter) {
  RL_969b4cd5a4260a685fb6fcf4e3b82dfe result = new RL_969b4cd5a4260a685fb6fcf4e3b82dfe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_969b4cd5a4260a685fb6fcf4e3b82dfe FromRestList<T>(RestList<T> restList, Func <T, ST_b6d345dd13582e4e92d7108f300179feStructure> converter) {
  RL_969b4cd5a4260a685fb6fcf4e3b82dfe result = new RL_969b4cd5a4260a685fb6fcf4e3b82dfe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_969b4cd5a4260a685fb6fcf4e3b82dfe() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b6d345dd13582e4e92d7108f300179feStructure> NewList() {
return new RL_969b4cd5a4260a685fb6fcf4e3b82dfe();
}


} // RL_969b4cd5a4260a685fb6fcf4e3b82dfe
}

