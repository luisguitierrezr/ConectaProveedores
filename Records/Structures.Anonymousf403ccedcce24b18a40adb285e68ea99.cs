namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (7cwD9OLMGEukCtsoXmjqmQ)
///  <code>RC_51831f8bbf408689b196be5dba3a91ea</code> that represents <code>OrderApprovalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderApprovalRecord
public partial struct RC_51831f8bbf408689b196be5dba3a91ea : ITypedRecord<RC_51831f8bbf408689b196be5dba3a91ea> {
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;


public static implicit operator EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord( RC_51831f8bbf408689b196be5dba3a91ea r) {
return r.ssENOrderApproval;
}

public static implicit operator RC_51831f8bbf408689b196be5dba3a91ea (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord r) {
RC_51831f8bbf408689b196be5dba3a91ea res = new RC_51831f8bbf408689b196be5dba3a91ea ();
res.ssENOrderApproval = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderApproval.ChangedAttributes = value;
}
get {
    return ssENOrderApproval.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_51831f8bbf408689b196be5dba3a91ea() {
OptimizedAttributes = null;
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderApproval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderApproval.Read( r, ref index);
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
public void ReadIM(RC_51831f8bbf408689b196be5dba3a91ea r) {
this = r;
}


public static bool operator == (RC_51831f8bbf408689b196be5dba3a91ea a, RC_51831f8bbf408689b196be5dba3a91ea b) {
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
return true;
}

public static bool operator != (RC_51831f8bbf408689b196be5dba3a91ea a, RC_51831f8bbf408689b196be5dba3a91ea b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_51831f8bbf408689b196be5dba3a91ea)) return false;
return (this == (RC_51831f8bbf408689b196be5dba3a91ea)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderApproval.InternalRecursiveSave();
}


public RC_51831f8bbf408689b196be5dba3a91ea Duplicate() {
RC_51831f8bbf408689b196be5dba3a91ea t;
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
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
if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderApproval.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderApproval.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
}
} // RC_51831f8bbf408689b196be5dba3a91ea
/// <summary>
/// RecordList type <code>OrderApprovalRecordList</code> that represents a record list of
///  <code>OrderApproval</code>
/// </summary>
public partial class RL_7d3e8b1b39200784907c841002075329 : GenericRecordList<RC_51831f8bbf408689b196be5dba3a91ea>, IEnumerable, IEnumerator {

protected override RC_51831f8bbf408689b196be5dba3a91ea GetElementDefaultValue() {
return new RC_51831f8bbf408689b196be5dba3a91ea();
}

public T[] ToArray<T>(Func<RC_51831f8bbf408689b196be5dba3a91ea, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7d3e8b1b39200784907c841002075329 recordList, Func<RC_51831f8bbf408689b196be5dba3a91ea, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7d3e8b1b39200784907c841002075329(RC_51831f8bbf408689b196be5dba3a91ea[] array) {
  RL_7d3e8b1b39200784907c841002075329 result = new RL_7d3e8b1b39200784907c841002075329();
result.InnerFromArray(array);
    return result;
}

public static RL_7d3e8b1b39200784907c841002075329 ToList<T>(T[] array, Func <T, RC_51831f8bbf408689b196be5dba3a91ea> converter) {
  RL_7d3e8b1b39200784907c841002075329 result = new RL_7d3e8b1b39200784907c841002075329();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7d3e8b1b39200784907c841002075329 FromRestList<T>(RestList<T> restList, Func <T, RC_51831f8bbf408689b196be5dba3a91ea> converter) {
  RL_7d3e8b1b39200784907c841002075329 result = new RL_7d3e8b1b39200784907c841002075329();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7d3e8b1b39200784907c841002075329() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_51831f8bbf408689b196be5dba3a91ea> NewList() {
return new RL_7d3e8b1b39200784907c841002075329();
}


} // RL_7d3e8b1b39200784907c841002075329
}

