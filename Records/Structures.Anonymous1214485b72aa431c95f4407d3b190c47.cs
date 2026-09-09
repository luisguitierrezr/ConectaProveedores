namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (W0gUEqpyHEOV9EB9OxkMRw)
///  <code>RC_1a23e477b6ae940b541edd1112bf0a6b</code> that represents <code>LINESRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LINESRecord
public partial struct RC_1a23e477b6ae940b541edd1112bf0a6b : ITypedRecord<RC_1a23e477b6ae940b541edd1112bf0a6b> {
internal static readonly GlobalObjectKey IdLINES = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d+QjGq62C5RUHt0REr8Kaw");

public ST_1ebe89bcb89e874288df8fa96ba9996fStructure ssSTLINES;


public static implicit operator ST_1ebe89bcb89e874288df8fa96ba9996fStructure( RC_1a23e477b6ae940b541edd1112bf0a6b r) {
return r.ssSTLINES;
}

public static implicit operator RC_1a23e477b6ae940b541edd1112bf0a6b (ST_1ebe89bcb89e874288df8fa96ba9996fStructure r) {
RC_1a23e477b6ae940b541edd1112bf0a6b res = new RC_1a23e477b6ae940b541edd1112bf0a6b ();
res.ssSTLINES = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1a23e477b6ae940b541edd1112bf0a6b() {
OptimizedAttributes = null;
ssSTLINES = new ST_1ebe89bcb89e874288df8fa96ba9996fStructure();
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
    ssSTLINES.OptimizedAttributes = value[0];
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
ssSTLINES.Read( r, ref index);
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
public void ReadIM(RC_1a23e477b6ae940b541edd1112bf0a6b r) {
this = r;
}


public static bool operator == (RC_1a23e477b6ae940b541edd1112bf0a6b a, RC_1a23e477b6ae940b541edd1112bf0a6b b) {
if (a.ssSTLINES != b.ssSTLINES) return false;
return true;
}

public static bool operator != (RC_1a23e477b6ae940b541edd1112bf0a6b a, RC_1a23e477b6ae940b541edd1112bf0a6b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1a23e477b6ae940b541edd1112bf0a6b)) return false;
return (this == (RC_1a23e477b6ae940b541edd1112bf0a6b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTLINES.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTLINES.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTLINES.InternalRecursiveSave();
}


public RC_1a23e477b6ae940b541edd1112bf0a6b Duplicate() {
RC_1a23e477b6ae940b541edd1112bf0a6b t;
t.ssSTLINES = (ST_1ebe89bcb89e874288df8fa96ba9996fStructure)this.ssSTLINES.Duplicate();
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
if (head == "lines") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LINES")) variable.Value = ssSTLINES; else variable.Optimized = true;
variable.SetFieldName("lines");
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
if (key == IdLINES) {
return ssSTLINES;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLINES.Key.AsGuid) {
return ssSTLINES;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTLINES.FillFromOther((IRecord) other.AttributeGet(IdLINES));
}
} // RC_1a23e477b6ae940b541edd1112bf0a6b
/// <summary>
/// RecordList type <code>LINESRecordList</code> that represents a record list of <code>LINES</code>
/// </summary>
public partial class RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 : GenericRecordList<RC_1a23e477b6ae940b541edd1112bf0a6b>, IEnumerable, IEnumerator {

protected override RC_1a23e477b6ae940b541edd1112bf0a6b GetElementDefaultValue() {
return new RC_1a23e477b6ae940b541edd1112bf0a6b();
}

public T[] ToArray<T>(Func<RC_1a23e477b6ae940b541edd1112bf0a6b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 recordList, Func<RC_1a23e477b6ae940b541edd1112bf0a6b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2(RC_1a23e477b6ae940b541edd1112bf0a6b[] array) {
  RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 result = new RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2();
result.InnerFromArray(array);
    return result;
}

public static RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 ToList<T>(T[] array, Func <T, RC_1a23e477b6ae940b541edd1112bf0a6b> converter) {
  RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 result = new RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 FromRestList<T>(RestList<T> restList, Func <T, RC_1a23e477b6ae940b541edd1112bf0a6b> converter) {
  RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2 result = new RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2() : base() {
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
protected override OSList<RC_1a23e477b6ae940b541edd1112bf0a6b> NewList() {
return new RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2();
}


} // RL_5063dbb6e7fc0fc8ebcc9b20cf16e4e2
}

