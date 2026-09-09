namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZhCNC4+x6kSS18MWu1S46w)
///  <code>RC_63089b8d4a985345e32fc40fca06b12a</code> that represent
/// s <code>T_FAC_PAG_CAB_OutRecord</code> <p>Description: </p>
/// </summary>
// Name: T_FAC_PAG_CAB_OutRecord
public partial struct RC_63089b8d4a985345e32fc40fca06b12a : ITypedRecord<RC_63089b8d4a985345e32fc40fca06b12a> {
internal static readonly GlobalObjectKey IdT_FAC_PAG_CAB_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jZsIY5hKRVPjL8QPygaxKg");

public ST_27647b039a03d40c5b921de2dccb61f4Structure ssSTT_FAC_PAG_CAB_Out;


public static implicit operator ST_27647b039a03d40c5b921de2dccb61f4Structure( RC_63089b8d4a985345e32fc40fca06b12a r) {
return r.ssSTT_FAC_PAG_CAB_Out;
}

public static implicit operator RC_63089b8d4a985345e32fc40fca06b12a (ST_27647b039a03d40c5b921de2dccb61f4Structure r) {
RC_63089b8d4a985345e32fc40fca06b12a res = new RC_63089b8d4a985345e32fc40fca06b12a ();
res.ssSTT_FAC_PAG_CAB_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_63089b8d4a985345e32fc40fca06b12a() {
OptimizedAttributes = null;
ssSTT_FAC_PAG_CAB_Out = new ST_27647b039a03d40c5b921de2dccb61f4Structure();
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
    ssSTT_FAC_PAG_CAB_Out.OptimizedAttributes = value[0];
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
ssSTT_FAC_PAG_CAB_Out.Read( r, ref index);
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
public void ReadIM(RC_63089b8d4a985345e32fc40fca06b12a r) {
this = r;
}


public static bool operator == (RC_63089b8d4a985345e32fc40fca06b12a a, RC_63089b8d4a985345e32fc40fca06b12a b) {
if (a.ssSTT_FAC_PAG_CAB_Out != b.ssSTT_FAC_PAG_CAB_Out) return false;
return true;
}

public static bool operator != (RC_63089b8d4a985345e32fc40fca06b12a a, RC_63089b8d4a985345e32fc40fca06b12a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_63089b8d4a985345e32fc40fca06b12a)) return false;
return (this == (RC_63089b8d4a985345e32fc40fca06b12a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_FAC_PAG_CAB_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_FAC_PAG_CAB_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_FAC_PAG_CAB_Out.InternalRecursiveSave();
}


public RC_63089b8d4a985345e32fc40fca06b12a Duplicate() {
RC_63089b8d4a985345e32fc40fca06b12a t;
t.ssSTT_FAC_PAG_CAB_Out = (ST_27647b039a03d40c5b921de2dccb61f4Structure)this.ssSTT_FAC_PAG_CAB_Out.Duplicate();
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
if (head == "t_fac_pag_cab_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_CAB_Out")) variable.Value = ssSTT_FAC_PAG_CAB_Out; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_cab_out");
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
if (key == IdT_FAC_PAG_CAB_Out) {
return ssSTT_FAC_PAG_CAB_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_FAC_PAG_CAB_Out.Key.AsGuid) {
return ssSTT_FAC_PAG_CAB_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_FAC_PAG_CAB_Out.FillFromOther((IRecord) other.AttributeGet(IdT_FAC_PAG_CAB_Out));
}
} // RC_63089b8d4a985345e32fc40fca06b12a
/// <summary>
/// RecordList type <code>T_FAC_PAG_CAB_OutRecordList</code> that represents a record list of
///  <code>T_FAC_PAG_CAB_Out</code>
/// </summary>
public partial class RL_ef40a297fbebcb3f5e3423a21978a3d5 : GenericRecordList<RC_63089b8d4a985345e32fc40fca06b12a>, IEnumerable, IEnumerator {

protected override RC_63089b8d4a985345e32fc40fca06b12a GetElementDefaultValue() {
return new RC_63089b8d4a985345e32fc40fca06b12a();
}

public T[] ToArray<T>(Func<RC_63089b8d4a985345e32fc40fca06b12a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ef40a297fbebcb3f5e3423a21978a3d5 recordList, Func<RC_63089b8d4a985345e32fc40fca06b12a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ef40a297fbebcb3f5e3423a21978a3d5(RC_63089b8d4a985345e32fc40fca06b12a[] array) {
  RL_ef40a297fbebcb3f5e3423a21978a3d5 result = new RL_ef40a297fbebcb3f5e3423a21978a3d5();
result.InnerFromArray(array);
    return result;
}

public static RL_ef40a297fbebcb3f5e3423a21978a3d5 ToList<T>(T[] array, Func <T, RC_63089b8d4a985345e32fc40fca06b12a> converter) {
  RL_ef40a297fbebcb3f5e3423a21978a3d5 result = new RL_ef40a297fbebcb3f5e3423a21978a3d5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ef40a297fbebcb3f5e3423a21978a3d5 FromRestList<T>(RestList<T> restList, Func <T, RC_63089b8d4a985345e32fc40fca06b12a> converter) {
  RL_ef40a297fbebcb3f5e3423a21978a3d5 result = new RL_ef40a297fbebcb3f5e3423a21978a3d5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ef40a297fbebcb3f5e3423a21978a3d5() : base() {
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
protected override OSList<RC_63089b8d4a985345e32fc40fca06b12a> NewList() {
return new RL_ef40a297fbebcb3f5e3423a21978a3d5();
}


} // RL_ef40a297fbebcb3f5e3423a21978a3d5
}

