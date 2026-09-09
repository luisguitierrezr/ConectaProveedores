namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ldwtzqq5PkO71MGPvzetQA)
///  <code>RC_e6b9726aff274819952457f299ef917a</code> that represent
/// s <code>ZMXMIMMF_EM_COSMOZReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_COSMOZReqRecord
public partial struct RC_e6b9726aff274819952457f299ef917a : ITypedRecord<RC_e6b9726aff274819952457f299ef917a> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_COSMOZReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*anK55if_GUiVJFfyme+Reg");

public ST_6c39e0afc2ffdcac366ab8f57e83669cStructure ssSTZMXMIMMF_EM_COSMOZReq;


public static implicit operator ST_6c39e0afc2ffdcac366ab8f57e83669cStructure( RC_e6b9726aff274819952457f299ef917a r) {
return r.ssSTZMXMIMMF_EM_COSMOZReq;
}

public static implicit operator RC_e6b9726aff274819952457f299ef917a (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure r) {
RC_e6b9726aff274819952457f299ef917a res = new RC_e6b9726aff274819952457f299ef917a ();
res.ssSTZMXMIMMF_EM_COSMOZReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e6b9726aff274819952457f299ef917a() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_COSMOZReq = new ST_6c39e0afc2ffdcac366ab8f57e83669cStructure();
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
    ssSTZMXMIMMF_EM_COSMOZReq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_COSMOZReq.Read( r, ref index);
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
public void ReadIM(RC_e6b9726aff274819952457f299ef917a r) {
this = r;
}


public static bool operator == (RC_e6b9726aff274819952457f299ef917a a, RC_e6b9726aff274819952457f299ef917a b) {
if (a.ssSTZMXMIMMF_EM_COSMOZReq != b.ssSTZMXMIMMF_EM_COSMOZReq) return false;
return true;
}

public static bool operator != (RC_e6b9726aff274819952457f299ef917a a, RC_e6b9726aff274819952457f299ef917a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e6b9726aff274819952457f299ef917a)) return false;
return (this == (RC_e6b9726aff274819952457f299ef917a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_COSMOZReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_COSMOZReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_COSMOZReq.InternalRecursiveSave();
}


public RC_e6b9726aff274819952457f299ef917a Duplicate() {
RC_e6b9726aff274819952457f299ef917a t;
t.ssSTZMXMIMMF_EM_COSMOZReq = (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure)this.ssSTZMXMIMMF_EM_COSMOZReq.Duplicate();
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
if (head == "zmxmimmf_em_cosmozreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_COSMOZReq")) variable.Value = ssSTZMXMIMMF_EM_COSMOZReq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_cosmozreq");
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
if (key == IdZMXMIMMF_EM_COSMOZReq) {
return ssSTZMXMIMMF_EM_COSMOZReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_COSMOZReq.Key.AsGuid) {
return ssSTZMXMIMMF_EM_COSMOZReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_COSMOZReq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_COSMOZReq));
}
} // RC_e6b9726aff274819952457f299ef917a
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_COSMOZReqRecordList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_COSMOZReq</code>
/// </summary>
public partial class RL_029206303f1d54895cf7117d681cb1ff : GenericRecordList<RC_e6b9726aff274819952457f299ef917a>, IEnumerable, IEnumerator {

protected override RC_e6b9726aff274819952457f299ef917a GetElementDefaultValue() {
return new RC_e6b9726aff274819952457f299ef917a();
}

public T[] ToArray<T>(Func<RC_e6b9726aff274819952457f299ef917a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_029206303f1d54895cf7117d681cb1ff recordList, Func<RC_e6b9726aff274819952457f299ef917a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_029206303f1d54895cf7117d681cb1ff(RC_e6b9726aff274819952457f299ef917a[] array) {
  RL_029206303f1d54895cf7117d681cb1ff result = new RL_029206303f1d54895cf7117d681cb1ff();
result.InnerFromArray(array);
    return result;
}

public static RL_029206303f1d54895cf7117d681cb1ff ToList<T>(T[] array, Func <T, RC_e6b9726aff274819952457f299ef917a> converter) {
  RL_029206303f1d54895cf7117d681cb1ff result = new RL_029206303f1d54895cf7117d681cb1ff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_029206303f1d54895cf7117d681cb1ff FromRestList<T>(RestList<T> restList, Func <T, RC_e6b9726aff274819952457f299ef917a> converter) {
  RL_029206303f1d54895cf7117d681cb1ff result = new RL_029206303f1d54895cf7117d681cb1ff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_029206303f1d54895cf7117d681cb1ff() : base() {
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
protected override OSList<RC_e6b9726aff274819952457f299ef917a> NewList() {
return new RL_029206303f1d54895cf7117d681cb1ff();
}


} // RL_029206303f1d54895cf7117d681cb1ff
}

