namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UzIi6J9hBUiof48Yl7YlWQ)
///  <code>RC_c8382e0b08ee9d5965e5aae5b17d6261</code> that represent
/// s <code>BusinessValueCategoryRecord</code> <p>Description: </p>
/// </summary>
// Name: BusinessValueCategoryRecord
public partial struct RC_c8382e0b08ee9d5965e5aae5b17d6261 : ITypedRecord<RC_c8382e0b08ee9d5965e5aae5b17d6261> {
internal static readonly GlobalObjectKey IdBusinessValueCategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Cy44yO4IWZ1l5arlsX1iYQ");

public EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord ssENBusinessValueCategory;


public static implicit operator EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord( RC_c8382e0b08ee9d5965e5aae5b17d6261 r) {
return r.ssENBusinessValueCategory;
}

public static implicit operator RC_c8382e0b08ee9d5965e5aae5b17d6261 (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord r) {
RC_c8382e0b08ee9d5965e5aae5b17d6261 res = new RC_c8382e0b08ee9d5965e5aae5b17d6261 ();
res.ssENBusinessValueCategory = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENBusinessValueCategory.ChangedAttributes = value;
}
get {
    return ssENBusinessValueCategory.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c8382e0b08ee9d5965e5aae5b17d6261() {
OptimizedAttributes = null;
ssENBusinessValueCategory = new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENBusinessValueCategory.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENBusinessValueCategory.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENBusinessValueCategory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENBusinessValueCategory.Read( r, ref index);
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
public void ReadIM(RC_c8382e0b08ee9d5965e5aae5b17d6261 r) {
this = r;
}


public static bool operator == (RC_c8382e0b08ee9d5965e5aae5b17d6261 a, RC_c8382e0b08ee9d5965e5aae5b17d6261 b) {
if (a.ssENBusinessValueCategory != b.ssENBusinessValueCategory) return false;
return true;
}

public static bool operator != (RC_c8382e0b08ee9d5965e5aae5b17d6261 a, RC_c8382e0b08ee9d5965e5aae5b17d6261 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c8382e0b08ee9d5965e5aae5b17d6261)) return false;
return (this == (RC_c8382e0b08ee9d5965e5aae5b17d6261)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENBusinessValueCategory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENBusinessValueCategory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENBusinessValueCategory.InternalRecursiveSave();
}


public RC_c8382e0b08ee9d5965e5aae5b17d6261 Duplicate() {
RC_c8382e0b08ee9d5965e5aae5b17d6261 t;
t.ssENBusinessValueCategory = (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord)this.ssENBusinessValueCategory.Duplicate();
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
if (head == "businessvaluecategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueCategory")) variable.Value = ssENBusinessValueCategory; else variable.Optimized = true;
variable.SetFieldName("businessvaluecategory");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENBusinessValueCategory.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENBusinessValueCategory.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBusinessValueCategory) {
return ssENBusinessValueCategory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBusinessValueCategory.Key.AsGuid) {
return ssENBusinessValueCategory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENBusinessValueCategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueCategory));
}
} // RC_c8382e0b08ee9d5965e5aae5b17d6261
/// <summary>
/// RecordList type <code>BusinessValueCategoryRecordList</code> that represents a record list of
///  <code>BusinessValueCategory</code>
/// </summary>
public partial class RL_901339470d357e86e0df985d0e6489f6 : GenericRecordList<RC_c8382e0b08ee9d5965e5aae5b17d6261>, IEnumerable, IEnumerator {

protected override RC_c8382e0b08ee9d5965e5aae5b17d6261 GetElementDefaultValue() {
return new RC_c8382e0b08ee9d5965e5aae5b17d6261();
}

public T[] ToArray<T>(Func<RC_c8382e0b08ee9d5965e5aae5b17d6261, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_901339470d357e86e0df985d0e6489f6 recordList, Func<RC_c8382e0b08ee9d5965e5aae5b17d6261, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_901339470d357e86e0df985d0e6489f6(RC_c8382e0b08ee9d5965e5aae5b17d6261[] array) {
  RL_901339470d357e86e0df985d0e6489f6 result = new RL_901339470d357e86e0df985d0e6489f6();
result.InnerFromArray(array);
    return result;
}

public static RL_901339470d357e86e0df985d0e6489f6 ToList<T>(T[] array, Func <T, RC_c8382e0b08ee9d5965e5aae5b17d6261> converter) {
  RL_901339470d357e86e0df985d0e6489f6 result = new RL_901339470d357e86e0df985d0e6489f6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_901339470d357e86e0df985d0e6489f6 FromRestList<T>(RestList<T> restList, Func <T, RC_c8382e0b08ee9d5965e5aae5b17d6261> converter) {
  RL_901339470d357e86e0df985d0e6489f6 result = new RL_901339470d357e86e0df985d0e6489f6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_901339470d357e86e0df985d0e6489f6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c8382e0b08ee9d5965e5aae5b17d6261> NewList() {
return new RL_901339470d357e86e0df985d0e6489f6();
}


} // RL_901339470d357e86e0df985d0e6489f6
}

