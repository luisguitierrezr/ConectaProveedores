namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JA6Px1ohF0aJMQl2MK5Hfg)
///  <code>RC_87a3063e6674014b4b345dce21ff4d84</code> that represent
/// s <code>BusinessValueSubcategoryRecord</code> <p>Description: </p>
/// </summary>
// Name: BusinessValueSubcategoryRecord
public partial struct RC_87a3063e6674014b4b345dce21ff4d84 : ITypedRecord<RC_87a3063e6674014b4b345dce21ff4d84> {
internal static readonly GlobalObjectKey IdBusinessValueSubcategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pgajh3RmSwFLNF3OIf9NhA");

public EN_f296fc330d9916f9de4aae18321e8388EntityRecord ssENBusinessValueSubcategory;


public static implicit operator EN_f296fc330d9916f9de4aae18321e8388EntityRecord( RC_87a3063e6674014b4b345dce21ff4d84 r) {
return r.ssENBusinessValueSubcategory;
}

public static implicit operator RC_87a3063e6674014b4b345dce21ff4d84 (EN_f296fc330d9916f9de4aae18321e8388EntityRecord r) {
RC_87a3063e6674014b4b345dce21ff4d84 res = new RC_87a3063e6674014b4b345dce21ff4d84 ();
res.ssENBusinessValueSubcategory = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENBusinessValueSubcategory.ChangedAttributes = value;
}
get {
    return ssENBusinessValueSubcategory.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_87a3063e6674014b4b345dce21ff4d84() {
OptimizedAttributes = null;
ssENBusinessValueSubcategory = new EN_f296fc330d9916f9de4aae18321e8388EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENBusinessValueSubcategory.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENBusinessValueSubcategory.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENBusinessValueSubcategory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENBusinessValueSubcategory.Read( r, ref index);
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
public void ReadIM(RC_87a3063e6674014b4b345dce21ff4d84 r) {
this = r;
}


public static bool operator == (RC_87a3063e6674014b4b345dce21ff4d84 a, RC_87a3063e6674014b4b345dce21ff4d84 b) {
if (a.ssENBusinessValueSubcategory != b.ssENBusinessValueSubcategory) return false;
return true;
}

public static bool operator != (RC_87a3063e6674014b4b345dce21ff4d84 a, RC_87a3063e6674014b4b345dce21ff4d84 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_87a3063e6674014b4b345dce21ff4d84)) return false;
return (this == (RC_87a3063e6674014b4b345dce21ff4d84)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENBusinessValueSubcategory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENBusinessValueSubcategory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENBusinessValueSubcategory.InternalRecursiveSave();
}


public RC_87a3063e6674014b4b345dce21ff4d84 Duplicate() {
RC_87a3063e6674014b4b345dce21ff4d84 t;
t.ssENBusinessValueSubcategory = (EN_f296fc330d9916f9de4aae18321e8388EntityRecord)this.ssENBusinessValueSubcategory.Duplicate();
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
if (head == "businessvaluesubcategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueSubcategory")) variable.Value = ssENBusinessValueSubcategory; else variable.Optimized = true;
variable.SetFieldName("businessvaluesubcategory");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENBusinessValueSubcategory.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENBusinessValueSubcategory.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBusinessValueSubcategory) {
return ssENBusinessValueSubcategory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBusinessValueSubcategory.Key.AsGuid) {
return ssENBusinessValueSubcategory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENBusinessValueSubcategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueSubcategory));
}
} // RC_87a3063e6674014b4b345dce21ff4d84
/// <summary>
/// RecordList type <code>BusinessValueSubcategoryRecordList</code> that represents a record list of
///  <code>BusinessValueSubcategory</code>
/// </summary>
public partial class RL_2d11b20156650990ba0f3131aaaad2ea : GenericRecordList<RC_87a3063e6674014b4b345dce21ff4d84>, IEnumerable, IEnumerator {

protected override RC_87a3063e6674014b4b345dce21ff4d84 GetElementDefaultValue() {
return new RC_87a3063e6674014b4b345dce21ff4d84();
}

public T[] ToArray<T>(Func<RC_87a3063e6674014b4b345dce21ff4d84, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2d11b20156650990ba0f3131aaaad2ea recordList, Func<RC_87a3063e6674014b4b345dce21ff4d84, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2d11b20156650990ba0f3131aaaad2ea(RC_87a3063e6674014b4b345dce21ff4d84[] array) {
  RL_2d11b20156650990ba0f3131aaaad2ea result = new RL_2d11b20156650990ba0f3131aaaad2ea();
result.InnerFromArray(array);
    return result;
}

public static RL_2d11b20156650990ba0f3131aaaad2ea ToList<T>(T[] array, Func <T, RC_87a3063e6674014b4b345dce21ff4d84> converter) {
  RL_2d11b20156650990ba0f3131aaaad2ea result = new RL_2d11b20156650990ba0f3131aaaad2ea();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2d11b20156650990ba0f3131aaaad2ea FromRestList<T>(RestList<T> restList, Func <T, RC_87a3063e6674014b4b345dce21ff4d84> converter) {
  RL_2d11b20156650990ba0f3131aaaad2ea result = new RL_2d11b20156650990ba0f3131aaaad2ea();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2d11b20156650990ba0f3131aaaad2ea() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_87a3063e6674014b4b345dce21ff4d84> NewList() {
return new RL_2d11b20156650990ba0f3131aaaad2ea();
}


} // RL_2d11b20156650990ba0f3131aaaad2ea
}

