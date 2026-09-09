namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JBS1NTEM9EOqYQ6ppUAD0Q)
///  <code>RC_a64eb89b2a60d0e75a7895ec0d3f2a26</code> that represent
/// s <code>DocumentExtrationAccountRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationAccountRecord
public partial struct RC_a64eb89b2a60d0e75a7895ec0d3f2a26 : ITypedRecord<RC_a64eb89b2a60d0e75a7895ec0d3f2a26> {
internal static readonly GlobalObjectKey IdDocumentExtrationAccount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*m7hOpmAq59BaeJXsDT8qJg");

public ST_1074864f28737110728a1225e98b6e34Structure ssSTDocumentExtrationAccount;


public static implicit operator ST_1074864f28737110728a1225e98b6e34Structure( RC_a64eb89b2a60d0e75a7895ec0d3f2a26 r) {
return r.ssSTDocumentExtrationAccount;
}

public static implicit operator RC_a64eb89b2a60d0e75a7895ec0d3f2a26 (ST_1074864f28737110728a1225e98b6e34Structure r) {
RC_a64eb89b2a60d0e75a7895ec0d3f2a26 res = new RC_a64eb89b2a60d0e75a7895ec0d3f2a26 ();
res.ssSTDocumentExtrationAccount = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a64eb89b2a60d0e75a7895ec0d3f2a26() {
OptimizedAttributes = null;
ssSTDocumentExtrationAccount = new ST_1074864f28737110728a1225e98b6e34Structure();
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
    ssSTDocumentExtrationAccount.OptimizedAttributes = value[0];
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
ssSTDocumentExtrationAccount.Read( r, ref index);
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
public void ReadIM(RC_a64eb89b2a60d0e75a7895ec0d3f2a26 r) {
this = r;
}


public static bool operator == (RC_a64eb89b2a60d0e75a7895ec0d3f2a26 a, RC_a64eb89b2a60d0e75a7895ec0d3f2a26 b) {
if (a.ssSTDocumentExtrationAccount != b.ssSTDocumentExtrationAccount) return false;
return true;
}

public static bool operator != (RC_a64eb89b2a60d0e75a7895ec0d3f2a26 a, RC_a64eb89b2a60d0e75a7895ec0d3f2a26 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a64eb89b2a60d0e75a7895ec0d3f2a26)) return false;
return (this == (RC_a64eb89b2a60d0e75a7895ec0d3f2a26)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationAccount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationAccount.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationAccount.InternalRecursiveSave();
}


public RC_a64eb89b2a60d0e75a7895ec0d3f2a26 Duplicate() {
RC_a64eb89b2a60d0e75a7895ec0d3f2a26 t;
t.ssSTDocumentExtrationAccount = (ST_1074864f28737110728a1225e98b6e34Structure)this.ssSTDocumentExtrationAccount.Duplicate();
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
if (head == "documentextrationaccount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationAccount")) variable.Value = ssSTDocumentExtrationAccount; else variable.Optimized = true;
variable.SetFieldName("documentextrationaccount");
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
if (key == IdDocumentExtrationAccount) {
return ssSTDocumentExtrationAccount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationAccount.Key.AsGuid) {
return ssSTDocumentExtrationAccount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationAccount.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationAccount));
}
} // RC_a64eb89b2a60d0e75a7895ec0d3f2a26
/// <summary>
/// RecordList type <code>DocumentExtrationAccountRecordList</code> that represents a record list of
///  <code>DocumentExtrationAccount</code>
/// </summary>
public partial class RL_bb525a2399c7e59c77f96d7fa443808c : GenericRecordList<RC_a64eb89b2a60d0e75a7895ec0d3f2a26>, IEnumerable, IEnumerator {

protected override RC_a64eb89b2a60d0e75a7895ec0d3f2a26 GetElementDefaultValue() {
return new RC_a64eb89b2a60d0e75a7895ec0d3f2a26();
}

public T[] ToArray<T>(Func<RC_a64eb89b2a60d0e75a7895ec0d3f2a26, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb525a2399c7e59c77f96d7fa443808c recordList, Func<RC_a64eb89b2a60d0e75a7895ec0d3f2a26, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb525a2399c7e59c77f96d7fa443808c(RC_a64eb89b2a60d0e75a7895ec0d3f2a26[] array) {
  RL_bb525a2399c7e59c77f96d7fa443808c result = new RL_bb525a2399c7e59c77f96d7fa443808c();
result.InnerFromArray(array);
    return result;
}

public static RL_bb525a2399c7e59c77f96d7fa443808c ToList<T>(T[] array, Func <T, RC_a64eb89b2a60d0e75a7895ec0d3f2a26> converter) {
  RL_bb525a2399c7e59c77f96d7fa443808c result = new RL_bb525a2399c7e59c77f96d7fa443808c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb525a2399c7e59c77f96d7fa443808c FromRestList<T>(RestList<T> restList, Func <T, RC_a64eb89b2a60d0e75a7895ec0d3f2a26> converter) {
  RL_bb525a2399c7e59c77f96d7fa443808c result = new RL_bb525a2399c7e59c77f96d7fa443808c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb525a2399c7e59c77f96d7fa443808c() : base() {
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
protected override OSList<RC_a64eb89b2a60d0e75a7895ec0d3f2a26> NewList() {
return new RL_bb525a2399c7e59c77f96d7fa443808c();
}


} // RL_bb525a2399c7e59c77f96d7fa443808c
}

