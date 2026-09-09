namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Ply5O+0Ae02bviURHinkEw)
///  <code>RC_ca426fec0751e5b6dcf015e9fdc2120e</code> that represents <code>SizeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SizeRecord
public partial struct RC_ca426fec0751e5b6dcf015e9fdc2120e : ITypedRecord<RC_ca426fec0751e5b6dcf015e9fdc2120e> {
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7G9CylEHtuXc8BXp_cISDg");

public EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord ssENSize;


public static implicit operator EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord( RC_ca426fec0751e5b6dcf015e9fdc2120e r) {
return r.ssENSize;
}

public static implicit operator RC_ca426fec0751e5b6dcf015e9fdc2120e (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord r) {
RC_ca426fec0751e5b6dcf015e9fdc2120e res = new RC_ca426fec0751e5b6dcf015e9fdc2120e ();
res.ssENSize = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSize.ChangedAttributes = value;
}
get {
    return ssENSize.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ca426fec0751e5b6dcf015e9fdc2120e() {
OptimizedAttributes = null;
ssENSize = new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSize.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSize.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSize.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSize.Read( r, ref index);
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
public void ReadIM(RC_ca426fec0751e5b6dcf015e9fdc2120e r) {
this = r;
}


public static bool operator == (RC_ca426fec0751e5b6dcf015e9fdc2120e a, RC_ca426fec0751e5b6dcf015e9fdc2120e b) {
if (a.ssENSize != b.ssENSize) return false;
return true;
}

public static bool operator != (RC_ca426fec0751e5b6dcf015e9fdc2120e a, RC_ca426fec0751e5b6dcf015e9fdc2120e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ca426fec0751e5b6dcf015e9fdc2120e)) return false;
return (this == (RC_ca426fec0751e5b6dcf015e9fdc2120e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSize.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSize.InternalRecursiveSave();
}


public RC_ca426fec0751e5b6dcf015e9fdc2120e Duplicate() {
RC_ca426fec0751e5b6dcf015e9fdc2120e t;
t.ssENSize = (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord)this.ssENSize.Duplicate();
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
if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssENSize; else variable.Optimized = true;
variable.SetFieldName("size");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSize.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSize.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSize) {
return ssENSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSize.Key.AsGuid) {
return ssENSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSize.FillFromOther((IRecord) other.AttributeGet(IdSize));
}
} // RC_ca426fec0751e5b6dcf015e9fdc2120e
/// <summary>
/// RecordList type <code>SizeRecordList</code> that represents a record list of <code>Size</code>
/// </summary>
public partial class RL_27a81319ef1cef112a91632cbf388562 : GenericRecordList<RC_ca426fec0751e5b6dcf015e9fdc2120e>, IEnumerable, IEnumerator {

protected override RC_ca426fec0751e5b6dcf015e9fdc2120e GetElementDefaultValue() {
return new RC_ca426fec0751e5b6dcf015e9fdc2120e();
}

public T[] ToArray<T>(Func<RC_ca426fec0751e5b6dcf015e9fdc2120e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_27a81319ef1cef112a91632cbf388562 recordList, Func<RC_ca426fec0751e5b6dcf015e9fdc2120e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_27a81319ef1cef112a91632cbf388562(RC_ca426fec0751e5b6dcf015e9fdc2120e[] array) {
  RL_27a81319ef1cef112a91632cbf388562 result = new RL_27a81319ef1cef112a91632cbf388562();
result.InnerFromArray(array);
    return result;
}

public static RL_27a81319ef1cef112a91632cbf388562 ToList<T>(T[] array, Func <T, RC_ca426fec0751e5b6dcf015e9fdc2120e> converter) {
  RL_27a81319ef1cef112a91632cbf388562 result = new RL_27a81319ef1cef112a91632cbf388562();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_27a81319ef1cef112a91632cbf388562 FromRestList<T>(RestList<T> restList, Func <T, RC_ca426fec0751e5b6dcf015e9fdc2120e> converter) {
  RL_27a81319ef1cef112a91632cbf388562 result = new RL_27a81319ef1cef112a91632cbf388562();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_27a81319ef1cef112a91632cbf388562() : base() {
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
protected override OSList<RC_ca426fec0751e5b6dcf015e9fdc2120e> NewList() {
return new RL_27a81319ef1cef112a91632cbf388562();
}


} // RL_27a81319ef1cef112a91632cbf388562
}

