namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (VZa79odeb02IT8aMqhI+8g)
///  <code>RC_e3607d6b92545e5793fbeb99fc16b7e7</code> that represent
/// s <code>SideMenuBehaviorRecord</code> <p>Description: </p>
/// </summary>
// Name: SideMenuBehaviorRecord
public partial struct RC_e3607d6b92545e5793fbeb99fc16b7e7 : ITypedRecord<RC_e3607d6b92545e5793fbeb99fc16b7e7> {
internal static readonly GlobalObjectKey IdSideMenuBehavior = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a31g41SSV16T++uZ_Ba35w");

public EN_c1e622743b79c1510fd62a0adf89686bEntityRecord ssENSideMenuBehavior;


public static implicit operator EN_c1e622743b79c1510fd62a0adf89686bEntityRecord( RC_e3607d6b92545e5793fbeb99fc16b7e7 r) {
return r.ssENSideMenuBehavior;
}

public static implicit operator RC_e3607d6b92545e5793fbeb99fc16b7e7 (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord r) {
RC_e3607d6b92545e5793fbeb99fc16b7e7 res = new RC_e3607d6b92545e5793fbeb99fc16b7e7 ();
res.ssENSideMenuBehavior = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSideMenuBehavior.ChangedAttributes = value;
}
get {
    return ssENSideMenuBehavior.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e3607d6b92545e5793fbeb99fc16b7e7() {
OptimizedAttributes = null;
ssENSideMenuBehavior = new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSideMenuBehavior.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSideMenuBehavior.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSideMenuBehavior.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSideMenuBehavior.Read( r, ref index);
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
public void ReadIM(RC_e3607d6b92545e5793fbeb99fc16b7e7 r) {
this = r;
}


public static bool operator == (RC_e3607d6b92545e5793fbeb99fc16b7e7 a, RC_e3607d6b92545e5793fbeb99fc16b7e7 b) {
if (a.ssENSideMenuBehavior != b.ssENSideMenuBehavior) return false;
return true;
}

public static bool operator != (RC_e3607d6b92545e5793fbeb99fc16b7e7 a, RC_e3607d6b92545e5793fbeb99fc16b7e7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e3607d6b92545e5793fbeb99fc16b7e7)) return false;
return (this == (RC_e3607d6b92545e5793fbeb99fc16b7e7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSideMenuBehavior.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSideMenuBehavior.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSideMenuBehavior.InternalRecursiveSave();
}


public RC_e3607d6b92545e5793fbeb99fc16b7e7 Duplicate() {
RC_e3607d6b92545e5793fbeb99fc16b7e7 t;
t.ssENSideMenuBehavior = (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord)this.ssENSideMenuBehavior.Duplicate();
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
if (head == "sidemenubehavior") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SideMenuBehavior")) variable.Value = ssENSideMenuBehavior; else variable.Optimized = true;
variable.SetFieldName("sidemenubehavior");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSideMenuBehavior.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSideMenuBehavior.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSideMenuBehavior) {
return ssENSideMenuBehavior;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSideMenuBehavior.Key.AsGuid) {
return ssENSideMenuBehavior;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSideMenuBehavior.FillFromOther((IRecord) other.AttributeGet(IdSideMenuBehavior));
}
} // RC_e3607d6b92545e5793fbeb99fc16b7e7
/// <summary>
/// RecordList type <code>SideMenuBehaviorRecordList</code> that represents a record list of
///  <code>SideMenuBehavior</code>
/// </summary>
public partial class RL_f1db162aca08aae7be68b7aedc571752 : GenericRecordList<RC_e3607d6b92545e5793fbeb99fc16b7e7>, IEnumerable, IEnumerator {

protected override RC_e3607d6b92545e5793fbeb99fc16b7e7 GetElementDefaultValue() {
return new RC_e3607d6b92545e5793fbeb99fc16b7e7();
}

public T[] ToArray<T>(Func<RC_e3607d6b92545e5793fbeb99fc16b7e7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f1db162aca08aae7be68b7aedc571752 recordList, Func<RC_e3607d6b92545e5793fbeb99fc16b7e7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f1db162aca08aae7be68b7aedc571752(RC_e3607d6b92545e5793fbeb99fc16b7e7[] array) {
  RL_f1db162aca08aae7be68b7aedc571752 result = new RL_f1db162aca08aae7be68b7aedc571752();
result.InnerFromArray(array);
    return result;
}

public static RL_f1db162aca08aae7be68b7aedc571752 ToList<T>(T[] array, Func <T, RC_e3607d6b92545e5793fbeb99fc16b7e7> converter) {
  RL_f1db162aca08aae7be68b7aedc571752 result = new RL_f1db162aca08aae7be68b7aedc571752();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f1db162aca08aae7be68b7aedc571752 FromRestList<T>(RestList<T> restList, Func <T, RC_e3607d6b92545e5793fbeb99fc16b7e7> converter) {
  RL_f1db162aca08aae7be68b7aedc571752 result = new RL_f1db162aca08aae7be68b7aedc571752();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f1db162aca08aae7be68b7aedc571752() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e3607d6b92545e5793fbeb99fc16b7e7> NewList() {
return new RL_f1db162aca08aae7be68b7aedc571752();
}


} // RL_f1db162aca08aae7be68b7aedc571752
}

