namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EA3JySBq1UamjgyH8Iumgw)
///  <code>RC_9589ecc0629788c2aca6b47bcbae782c</code> that represents <code>SpaceRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SpaceRecord
public partial struct RC_9589ecc0629788c2aca6b47bcbae782c : ITypedRecord<RC_9589ecc0629788c2aca6b47bcbae782c> {
internal static readonly GlobalObjectKey IdSpace = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wOyJlZdiwoisprR7y654LA");

public EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord ssENSpace;


public static implicit operator EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord( RC_9589ecc0629788c2aca6b47bcbae782c r) {
return r.ssENSpace;
}

public static implicit operator RC_9589ecc0629788c2aca6b47bcbae782c (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord r) {
RC_9589ecc0629788c2aca6b47bcbae782c res = new RC_9589ecc0629788c2aca6b47bcbae782c ();
res.ssENSpace = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSpace.ChangedAttributes = value;
}
get {
    return ssENSpace.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_9589ecc0629788c2aca6b47bcbae782c() {
OptimizedAttributes = null;
ssENSpace = new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSpace.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSpace.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSpace.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSpace.Read( r, ref index);
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
public void ReadIM(RC_9589ecc0629788c2aca6b47bcbae782c r) {
this = r;
}


public static bool operator == (RC_9589ecc0629788c2aca6b47bcbae782c a, RC_9589ecc0629788c2aca6b47bcbae782c b) {
if (a.ssENSpace != b.ssENSpace) return false;
return true;
}

public static bool operator != (RC_9589ecc0629788c2aca6b47bcbae782c a, RC_9589ecc0629788c2aca6b47bcbae782c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9589ecc0629788c2aca6b47bcbae782c)) return false;
return (this == (RC_9589ecc0629788c2aca6b47bcbae782c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSpace.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSpace.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSpace.InternalRecursiveSave();
}


public RC_9589ecc0629788c2aca6b47bcbae782c Duplicate() {
RC_9589ecc0629788c2aca6b47bcbae782c t;
t.ssENSpace = (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord)this.ssENSpace.Duplicate();
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
if (head == "space") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space")) variable.Value = ssENSpace; else variable.Optimized = true;
variable.SetFieldName("space");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSpace.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSpace.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpace) {
return ssENSpace;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpace.Key.AsGuid) {
return ssENSpace;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSpace.FillFromOther((IRecord) other.AttributeGet(IdSpace));
}
} // RC_9589ecc0629788c2aca6b47bcbae782c
/// <summary>
/// RecordList type <code>SpaceRecordList</code> that represents a record list of <code>Space</code>
/// </summary>
public partial class RL_021cf4e3f37562560ed722ed4a5446c1 : GenericRecordList<RC_9589ecc0629788c2aca6b47bcbae782c>, IEnumerable, IEnumerator {

protected override RC_9589ecc0629788c2aca6b47bcbae782c GetElementDefaultValue() {
return new RC_9589ecc0629788c2aca6b47bcbae782c();
}

public T[] ToArray<T>(Func<RC_9589ecc0629788c2aca6b47bcbae782c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_021cf4e3f37562560ed722ed4a5446c1 recordList, Func<RC_9589ecc0629788c2aca6b47bcbae782c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_021cf4e3f37562560ed722ed4a5446c1(RC_9589ecc0629788c2aca6b47bcbae782c[] array) {
  RL_021cf4e3f37562560ed722ed4a5446c1 result = new RL_021cf4e3f37562560ed722ed4a5446c1();
result.InnerFromArray(array);
    return result;
}

public static RL_021cf4e3f37562560ed722ed4a5446c1 ToList<T>(T[] array, Func <T, RC_9589ecc0629788c2aca6b47bcbae782c> converter) {
  RL_021cf4e3f37562560ed722ed4a5446c1 result = new RL_021cf4e3f37562560ed722ed4a5446c1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_021cf4e3f37562560ed722ed4a5446c1 FromRestList<T>(RestList<T> restList, Func <T, RC_9589ecc0629788c2aca6b47bcbae782c> converter) {
  RL_021cf4e3f37562560ed722ed4a5446c1 result = new RL_021cf4e3f37562560ed722ed4a5446c1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_021cf4e3f37562560ed722ed4a5446c1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9589ecc0629788c2aca6b47bcbae782c> NewList() {
return new RL_021cf4e3f37562560ed722ed4a5446c1();
}


} // RL_021cf4e3f37562560ed722ed4a5446c1
}

