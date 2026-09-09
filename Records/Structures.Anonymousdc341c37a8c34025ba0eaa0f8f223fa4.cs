namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Nxw03MOoJUC6DqoPjyI_pA)
///  <code>RC_dade6177501c5e7875e9a6382991b5bd</code> that represent
/// s <code>EmailsNotifStringRecord</code> <p>Description: </p>
/// </summary>
// Name: EmailsNotifStringRecord
public partial struct RC_dade6177501c5e7875e9a6382991b5bd : ITypedRecord<RC_dade6177501c5e7875e9a6382991b5bd> {
internal static readonly GlobalObjectKey IdEmailsNotifString = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d2He2hxQeF516aY4KZG1vQ");

public ST_ec0355ea9ae479e83019f837aa06cae8Structure ssSTEmailsNotifString;


public static implicit operator ST_ec0355ea9ae479e83019f837aa06cae8Structure( RC_dade6177501c5e7875e9a6382991b5bd r) {
return r.ssSTEmailsNotifString;
}

public static implicit operator RC_dade6177501c5e7875e9a6382991b5bd (ST_ec0355ea9ae479e83019f837aa06cae8Structure r) {
RC_dade6177501c5e7875e9a6382991b5bd res = new RC_dade6177501c5e7875e9a6382991b5bd ();
res.ssSTEmailsNotifString = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dade6177501c5e7875e9a6382991b5bd() {
OptimizedAttributes = null;
ssSTEmailsNotifString = new ST_ec0355ea9ae479e83019f837aa06cae8Structure();
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
    ssSTEmailsNotifString.OptimizedAttributes = value[0];
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
ssSTEmailsNotifString.Read( r, ref index);
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
public void ReadIM(RC_dade6177501c5e7875e9a6382991b5bd r) {
this = r;
}


public static bool operator == (RC_dade6177501c5e7875e9a6382991b5bd a, RC_dade6177501c5e7875e9a6382991b5bd b) {
if (a.ssSTEmailsNotifString != b.ssSTEmailsNotifString) return false;
return true;
}

public static bool operator != (RC_dade6177501c5e7875e9a6382991b5bd a, RC_dade6177501c5e7875e9a6382991b5bd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dade6177501c5e7875e9a6382991b5bd)) return false;
return (this == (RC_dade6177501c5e7875e9a6382991b5bd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEmailsNotifString.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEmailsNotifString.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEmailsNotifString.InternalRecursiveSave();
}


public RC_dade6177501c5e7875e9a6382991b5bd Duplicate() {
RC_dade6177501c5e7875e9a6382991b5bd t;
t.ssSTEmailsNotifString = (ST_ec0355ea9ae479e83019f837aa06cae8Structure)this.ssSTEmailsNotifString.Duplicate();
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
if (head == "emailsnotifstring") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmailsNotifString")) variable.Value = ssSTEmailsNotifString; else variable.Optimized = true;
variable.SetFieldName("emailsnotifstring");
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
if (key == IdEmailsNotifString) {
return ssSTEmailsNotifString;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmailsNotifString.Key.AsGuid) {
return ssSTEmailsNotifString;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEmailsNotifString.FillFromOther((IRecord) other.AttributeGet(IdEmailsNotifString));
}
} // RC_dade6177501c5e7875e9a6382991b5bd
/// <summary>
/// RecordList type <code>EmailsNotifStringRecordList</code> that represents a record list of
///  <code>EmailsNotifString</code>
/// </summary>
public partial class RL_31fac59bc456dc76c5f04eb2b106ef9e : GenericRecordList<RC_dade6177501c5e7875e9a6382991b5bd>, IEnumerable, IEnumerator {

protected override RC_dade6177501c5e7875e9a6382991b5bd GetElementDefaultValue() {
return new RC_dade6177501c5e7875e9a6382991b5bd();
}

public T[] ToArray<T>(Func<RC_dade6177501c5e7875e9a6382991b5bd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_31fac59bc456dc76c5f04eb2b106ef9e recordList, Func<RC_dade6177501c5e7875e9a6382991b5bd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_31fac59bc456dc76c5f04eb2b106ef9e(RC_dade6177501c5e7875e9a6382991b5bd[] array) {
  RL_31fac59bc456dc76c5f04eb2b106ef9e result = new RL_31fac59bc456dc76c5f04eb2b106ef9e();
result.InnerFromArray(array);
    return result;
}

public static RL_31fac59bc456dc76c5f04eb2b106ef9e ToList<T>(T[] array, Func <T, RC_dade6177501c5e7875e9a6382991b5bd> converter) {
  RL_31fac59bc456dc76c5f04eb2b106ef9e result = new RL_31fac59bc456dc76c5f04eb2b106ef9e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_31fac59bc456dc76c5f04eb2b106ef9e FromRestList<T>(RestList<T> restList, Func <T, RC_dade6177501c5e7875e9a6382991b5bd> converter) {
  RL_31fac59bc456dc76c5f04eb2b106ef9e result = new RL_31fac59bc456dc76c5f04eb2b106ef9e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_31fac59bc456dc76c5f04eb2b106ef9e() : base() {
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
protected override OSList<RC_dade6177501c5e7875e9a6382991b5bd> NewList() {
return new RL_31fac59bc456dc76c5f04eb2b106ef9e();
}


} // RL_31fac59bc456dc76c5f04eb2b106ef9e
}

