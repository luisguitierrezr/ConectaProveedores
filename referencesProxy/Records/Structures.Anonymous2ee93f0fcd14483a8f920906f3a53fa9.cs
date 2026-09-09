namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Dz_pLhTNOkiPkgkG86U_qQ)
///  <code>RC_df25272b507942fc4acdb95756118e7f</code> that represents <code>IT_ATTACHMENTRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: IT_ATTACHMENTRecord
public partial struct RC_df25272b507942fc4acdb95756118e7f : ITypedRecord<RC_df25272b507942fc4acdb95756118e7f> {
internal static readonly GlobalObjectKey IdIT_ATTACHMENT = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Kycl33lQ_EJKzblXVhGOfw");

public ST_7816c3c943d129234de46d39c32a618eStructure ssSTIT_ATTACHMENT;


public static implicit operator ST_7816c3c943d129234de46d39c32a618eStructure( RC_df25272b507942fc4acdb95756118e7f r) {
return r.ssSTIT_ATTACHMENT;
}

public static implicit operator RC_df25272b507942fc4acdb95756118e7f (ST_7816c3c943d129234de46d39c32a618eStructure r) {
RC_df25272b507942fc4acdb95756118e7f res = new RC_df25272b507942fc4acdb95756118e7f ();
res.ssSTIT_ATTACHMENT = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_df25272b507942fc4acdb95756118e7f() {
OptimizedAttributes = null;
ssSTIT_ATTACHMENT = new ST_7816c3c943d129234de46d39c32a618eStructure();
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
    ssSTIT_ATTACHMENT.OptimizedAttributes = value[0];
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
ssSTIT_ATTACHMENT.Read( r, ref index);
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
public void ReadIM(RC_df25272b507942fc4acdb95756118e7f r) {
this = r;
}


public static bool operator == (RC_df25272b507942fc4acdb95756118e7f a, RC_df25272b507942fc4acdb95756118e7f b) {
if (a.ssSTIT_ATTACHMENT != b.ssSTIT_ATTACHMENT) return false;
return true;
}

public static bool operator != (RC_df25272b507942fc4acdb95756118e7f a, RC_df25272b507942fc4acdb95756118e7f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_df25272b507942fc4acdb95756118e7f)) return false;
return (this == (RC_df25272b507942fc4acdb95756118e7f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTIT_ATTACHMENT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTIT_ATTACHMENT.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTIT_ATTACHMENT.InternalRecursiveSave();
}


public RC_df25272b507942fc4acdb95756118e7f Duplicate() {
RC_df25272b507942fc4acdb95756118e7f t;
t.ssSTIT_ATTACHMENT = (ST_7816c3c943d129234de46d39c32a618eStructure)this.ssSTIT_ATTACHMENT.Duplicate();
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
if (head == "it_attachment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IT_ATTACHMENT")) variable.Value = ssSTIT_ATTACHMENT; else variable.Optimized = true;
variable.SetFieldName("it_attachment");
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
if (key == IdIT_ATTACHMENT) {
return ssSTIT_ATTACHMENT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIT_ATTACHMENT.Key.AsGuid) {
return ssSTIT_ATTACHMENT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTIT_ATTACHMENT.FillFromOther((IRecord) other.AttributeGet(IdIT_ATTACHMENT));
}
} // RC_df25272b507942fc4acdb95756118e7f
/// <summary>
/// RecordList type <code>IT_ATTACHMENTRecordList</code> that represents a record list of
///  <code>IT_ATTACHMENT</code>
/// </summary>
public partial class RL_35e8fb9746a2675b165bb06df6c5e54e : GenericRecordList<RC_df25272b507942fc4acdb95756118e7f>, IEnumerable, IEnumerator {

protected override RC_df25272b507942fc4acdb95756118e7f GetElementDefaultValue() {
return new RC_df25272b507942fc4acdb95756118e7f();
}

public T[] ToArray<T>(Func<RC_df25272b507942fc4acdb95756118e7f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_35e8fb9746a2675b165bb06df6c5e54e recordList, Func<RC_df25272b507942fc4acdb95756118e7f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_35e8fb9746a2675b165bb06df6c5e54e(RC_df25272b507942fc4acdb95756118e7f[] array) {
  RL_35e8fb9746a2675b165bb06df6c5e54e result = new RL_35e8fb9746a2675b165bb06df6c5e54e();
result.InnerFromArray(array);
    return result;
}

public static RL_35e8fb9746a2675b165bb06df6c5e54e ToList<T>(T[] array, Func <T, RC_df25272b507942fc4acdb95756118e7f> converter) {
  RL_35e8fb9746a2675b165bb06df6c5e54e result = new RL_35e8fb9746a2675b165bb06df6c5e54e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_35e8fb9746a2675b165bb06df6c5e54e FromRestList<T>(RestList<T> restList, Func <T, RC_df25272b507942fc4acdb95756118e7f> converter) {
  RL_35e8fb9746a2675b165bb06df6c5e54e result = new RL_35e8fb9746a2675b165bb06df6c5e54e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_35e8fb9746a2675b165bb06df6c5e54e() : base() {
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
protected override OSList<RC_df25272b507942fc4acdb95756118e7f> NewList() {
return new RL_35e8fb9746a2675b165bb06df6c5e54e();
}


} // RL_35e8fb9746a2675b165bb06df6c5e54e
}

