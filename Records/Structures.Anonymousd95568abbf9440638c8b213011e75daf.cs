namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (q2hV2ZS_Y0CMiyEwEeddrw)
///  <code>RC_64894cdb6c46279b2d012a58a7771333</code> that represents <code>ContractStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ContractStatusRecord
public partial struct RC_64894cdb6c46279b2d012a58a7771333 : ITypedRecord<RC_64894cdb6c46279b2d012a58a7771333> {
internal static readonly GlobalObjectKey IdContractStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*20yJZEZsmyctASpYp3cTMw");

public EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord ssENContractStatus;


public static implicit operator EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord( RC_64894cdb6c46279b2d012a58a7771333 r) {
return r.ssENContractStatus;
}

public static implicit operator RC_64894cdb6c46279b2d012a58a7771333 (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord r) {
RC_64894cdb6c46279b2d012a58a7771333 res = new RC_64894cdb6c46279b2d012a58a7771333 ();
res.ssENContractStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENContractStatus.ChangedAttributes = value;
}
get {
    return ssENContractStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_64894cdb6c46279b2d012a58a7771333() {
OptimizedAttributes = null;
ssENContractStatus = new EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENContractStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENContractStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENContractStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENContractStatus.Read( r, ref index);
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
public void ReadIM(RC_64894cdb6c46279b2d012a58a7771333 r) {
this = r;
}


public static bool operator == (RC_64894cdb6c46279b2d012a58a7771333 a, RC_64894cdb6c46279b2d012a58a7771333 b) {
if (a.ssENContractStatus != b.ssENContractStatus) return false;
return true;
}

public static bool operator != (RC_64894cdb6c46279b2d012a58a7771333 a, RC_64894cdb6c46279b2d012a58a7771333 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_64894cdb6c46279b2d012a58a7771333)) return false;
return (this == (RC_64894cdb6c46279b2d012a58a7771333)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENContractStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENContractStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENContractStatus.InternalRecursiveSave();
}


public RC_64894cdb6c46279b2d012a58a7771333 Duplicate() {
RC_64894cdb6c46279b2d012a58a7771333 t;
t.ssENContractStatus = (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord)this.ssENContractStatus.Duplicate();
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
if (head == "contractstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractStatus")) variable.Value = ssENContractStatus; else variable.Optimized = true;
variable.SetFieldName("contractstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENContractStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENContractStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdContractStatus) {
return ssENContractStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContractStatus.Key.AsGuid) {
return ssENContractStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENContractStatus.FillFromOther((IRecord) other.AttributeGet(IdContractStatus));
}
} // RC_64894cdb6c46279b2d012a58a7771333
/// <summary>
/// RecordList type <code>ContractStatusRecordList</code> that represents a record list of
///  <code>ContractStatus</code>
/// </summary>
public partial class RL_b597b6c7f7b0a874a3717792e87892bb : GenericRecordList<RC_64894cdb6c46279b2d012a58a7771333>, IEnumerable, IEnumerator {

protected override RC_64894cdb6c46279b2d012a58a7771333 GetElementDefaultValue() {
return new RC_64894cdb6c46279b2d012a58a7771333();
}

public T[] ToArray<T>(Func<RC_64894cdb6c46279b2d012a58a7771333, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b597b6c7f7b0a874a3717792e87892bb recordList, Func<RC_64894cdb6c46279b2d012a58a7771333, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b597b6c7f7b0a874a3717792e87892bb(RC_64894cdb6c46279b2d012a58a7771333[] array) {
  RL_b597b6c7f7b0a874a3717792e87892bb result = new RL_b597b6c7f7b0a874a3717792e87892bb();
result.InnerFromArray(array);
    return result;
}

public static RL_b597b6c7f7b0a874a3717792e87892bb ToList<T>(T[] array, Func <T, RC_64894cdb6c46279b2d012a58a7771333> converter) {
  RL_b597b6c7f7b0a874a3717792e87892bb result = new RL_b597b6c7f7b0a874a3717792e87892bb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b597b6c7f7b0a874a3717792e87892bb FromRestList<T>(RestList<T> restList, Func <T, RC_64894cdb6c46279b2d012a58a7771333> converter) {
  RL_b597b6c7f7b0a874a3717792e87892bb result = new RL_b597b6c7f7b0a874a3717792e87892bb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b597b6c7f7b0a874a3717792e87892bb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_64894cdb6c46279b2d012a58a7771333> NewList() {
return new RL_b597b6c7f7b0a874a3717792e87892bb();
}


} // RL_b597b6c7f7b0a874a3717792e87892bb
}

