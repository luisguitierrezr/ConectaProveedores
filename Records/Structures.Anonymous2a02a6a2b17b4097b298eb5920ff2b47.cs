namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oqYCKnuxl0CymOtZIP8rRw)
///  <code>RC_620c1ad5411dbb3ddbe0616529c19a2e</code> that represents <code>UserExtensionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserExtensionRecord
public partial struct RC_620c1ad5411dbb3ddbe0616529c19a2e : ITypedRecord<RC_620c1ad5411dbb3ddbe0616529c19a2e> {
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;


public static implicit operator EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord( RC_620c1ad5411dbb3ddbe0616529c19a2e r) {
return r.ssENUserExtension;
}

public static implicit operator RC_620c1ad5411dbb3ddbe0616529c19a2e (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord r) {
RC_620c1ad5411dbb3ddbe0616529c19a2e res = new RC_620c1ad5411dbb3ddbe0616529c19a2e ();
res.ssENUserExtension = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUserExtension.ChangedAttributes = value;
}
get {
    return ssENUserExtension.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_620c1ad5411dbb3ddbe0616529c19a2e() {
OptimizedAttributes = null;
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUserExtension.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUserExtension.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserExtension.Read( r, ref index);
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
public void ReadIM(RC_620c1ad5411dbb3ddbe0616529c19a2e r) {
this = r;
}


public static bool operator == (RC_620c1ad5411dbb3ddbe0616529c19a2e a, RC_620c1ad5411dbb3ddbe0616529c19a2e b) {
if (a.ssENUserExtension != b.ssENUserExtension) return false;
return true;
}

public static bool operator != (RC_620c1ad5411dbb3ddbe0616529c19a2e a, RC_620c1ad5411dbb3ddbe0616529c19a2e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_620c1ad5411dbb3ddbe0616529c19a2e)) return false;
return (this == (RC_620c1ad5411dbb3ddbe0616529c19a2e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserExtension.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserExtension.InternalRecursiveSave();
}


public RC_620c1ad5411dbb3ddbe0616529c19a2e Duplicate() {
RC_620c1ad5411dbb3ddbe0616529c19a2e t;
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
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
if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUserExtension.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUserExtension.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUserExtension) {
return ssENUserExtension;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
}
} // RC_620c1ad5411dbb3ddbe0616529c19a2e
/// <summary>
/// RecordList type <code>UserExtensionRecordList</code> that represents a record list of
///  <code>UserExtension</code>
/// </summary>
public partial class RL_d0d151ba05946a6343a844d0f7206496 : GenericRecordList<RC_620c1ad5411dbb3ddbe0616529c19a2e>, IEnumerable, IEnumerator {

protected override RC_620c1ad5411dbb3ddbe0616529c19a2e GetElementDefaultValue() {
return new RC_620c1ad5411dbb3ddbe0616529c19a2e();
}

public T[] ToArray<T>(Func<RC_620c1ad5411dbb3ddbe0616529c19a2e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d0d151ba05946a6343a844d0f7206496 recordList, Func<RC_620c1ad5411dbb3ddbe0616529c19a2e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d0d151ba05946a6343a844d0f7206496(RC_620c1ad5411dbb3ddbe0616529c19a2e[] array) {
  RL_d0d151ba05946a6343a844d0f7206496 result = new RL_d0d151ba05946a6343a844d0f7206496();
result.InnerFromArray(array);
    return result;
}

public static RL_d0d151ba05946a6343a844d0f7206496 ToList<T>(T[] array, Func <T, RC_620c1ad5411dbb3ddbe0616529c19a2e> converter) {
  RL_d0d151ba05946a6343a844d0f7206496 result = new RL_d0d151ba05946a6343a844d0f7206496();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d0d151ba05946a6343a844d0f7206496 FromRestList<T>(RestList<T> restList, Func <T, RC_620c1ad5411dbb3ddbe0616529c19a2e> converter) {
  RL_d0d151ba05946a6343a844d0f7206496 result = new RL_d0d151ba05946a6343a844d0f7206496();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d0d151ba05946a6343a844d0f7206496() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_620c1ad5411dbb3ddbe0616529c19a2e> NewList() {
return new RL_d0d151ba05946a6343a844d0f7206496();
}


} // RL_d0d151ba05946a6343a844d0f7206496
}

