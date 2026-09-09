namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZTC_GENERA_POLIZA_GRALReq (JXT2AZodLkO4g6eiZ+6XuA)
///  <code>ST_7d9ca3de97b3b074755ccb195cd9efb0Structure</code> that represent
/// s <code>ZTC_GENERA_POLIZA_GRALReq</code> <p>Description: ZTC_GENERA_POLIZA_GRALReq</p>
/// </summary>
// Name: ZTC_GENERA_POLIZA_GRALReq
public partial struct ST_7d9ca3de97b3b074755ccb195cd9efb0Structure : ITypedRecord<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure> {
internal static readonly GlobalObjectKey IdPI_USUARIO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*KHqJ_qvZqkawcN_vb_Gdow");
internal static readonly GlobalObjectKey IdTI_POS_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*+qXhjPnK7UOebYU5KAb1uw");
internal static readonly GlobalObjectKey IdTO_RESULTADO_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*L9TW_qryxkGKaPvf09FGOg");

public string ssPI_USUARIO;

public RL_c68103fa9d6dc1b51b6298518d880199 ssTI_POS_In;

public RL_d9182ea8cfe690c58e113da212e63df9 ssTO_RESULTADO_In;


public BitArray OptimizedAttributes;

public ST_7d9ca3de97b3b074755ccb195cd9efb0Structure() {
OptimizedAttributes = null;
ssPI_USUARIO = "";
ssTI_POS_In = new RL_c68103fa9d6dc1b51b6298518d880199();
ssTO_RESULTADO_In = new RL_d9182ea8cfe690c58e113da212e63df9();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPI_USUARIO = r.ReadText(index++, "ZTC_GENERA_POLIZA_GRALReq.PI_USUARIO", "");
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
public void ReadIM(ST_7d9ca3de97b3b074755ccb195cd9efb0Structure r) {
this = r;
}


public static bool operator == (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure a, ST_7d9ca3de97b3b074755ccb195cd9efb0Structure b) {
if (a.ssPI_USUARIO != b.ssPI_USUARIO) return false;
if (a.ssTI_POS_In != b.ssTI_POS_In) return false;
if (a.ssTO_RESULTADO_In != b.ssTO_RESULTADO_In) return false;
return true;
}

public static bool operator != (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure a, ST_7d9ca3de97b3b074755ccb195cd9efb0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure)) return false;
return (this == (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_USUARIO.GetHashCode()
 ^ ssTI_POS_In.GetHashCode()
 ^ ssTO_RESULTADO_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssTI_POS_In.RecursiveReset();
ssTO_RESULTADO_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssTI_POS_In.InternalRecursiveSave();
ssTO_RESULTADO_In.InternalRecursiveSave();
}


public ST_7d9ca3de97b3b074755ccb195cd9efb0Structure Duplicate() {
ST_7d9ca3de97b3b074755ccb195cd9efb0Structure t;
t.ssPI_USUARIO = this.ssPI_USUARIO;
t.ssTI_POS_In = (RL_c68103fa9d6dc1b51b6298518d880199)this.ssTI_POS_In.Duplicate();
t.ssTO_RESULTADO_In = (RL_d9182ea8cfe690c58e113da212e63df9)this.ssTO_RESULTADO_In.Duplicate();
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
if (head == "pi_usuario") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_USUARIO")) variable.Value = ssPI_USUARIO; else variable.Optimized = true;
} else if (head == "ti_pos_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_POS_In")) variable.Value = ssTI_POS_In; else variable.Optimized = true;
variable.SetFieldName("ti_pos_in");
} else if (head == "to_resultado_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TO_RESULTADO_In")) variable.Value = ssTO_RESULTADO_In; else variable.Optimized = true;
variable.SetFieldName("to_resultado_in");
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
if (key == IdPI_USUARIO) {
return ssPI_USUARIO;
}
if (key == IdTI_POS_In) {
return ssTI_POS_In;
}
if (key == IdTO_RESULTADO_In) {
return ssTO_RESULTADO_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_USUARIO.Key.AsGuid) {
return ssPI_USUARIO;
}
if (attributeKey == IdTI_POS_In.Key.AsGuid) {
return ssTI_POS_In;
}
if (attributeKey == IdTO_RESULTADO_In.Key.AsGuid) {
return ssTO_RESULTADO_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_USUARIO = (string) other.AttributeGet(IdPI_USUARIO);
ssTI_POS_In = new RL_c68103fa9d6dc1b51b6298518d880199();
ssTI_POS_In.FillFromOther((IOSList) other.AttributeGet(IdTI_POS_In));
ssTO_RESULTADO_In = new RL_d9182ea8cfe690c58e113da212e63df9();
ssTO_RESULTADO_In.FillFromOther((IOSList) other.AttributeGet(IdTO_RESULTADO_In));
}
} // ST_7d9ca3de97b3b074755ccb195cd9efb0Structure
/// <summary>
/// RecordList type <code>ZTC_GENERA_POLIZA_GRALReqList</code> that represents a record list of
///  <code>ZTC_GENERA_POLIZA_GRALReq</code>
/// </summary>
public partial class RL_5009a3db4bcc9428eb7b974bf968ae3e : GenericRecordList<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure>, IEnumerable, IEnumerator {

protected override ST_7d9ca3de97b3b074755ccb195cd9efb0Structure GetElementDefaultValue() {
return new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure();
}

public T[] ToArray<T>(Func<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5009a3db4bcc9428eb7b974bf968ae3e recordList, Func<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5009a3db4bcc9428eb7b974bf968ae3e(ST_7d9ca3de97b3b074755ccb195cd9efb0Structure[] array) {
  RL_5009a3db4bcc9428eb7b974bf968ae3e result = new RL_5009a3db4bcc9428eb7b974bf968ae3e();
result.InnerFromArray(array);
    return result;
}

public static RL_5009a3db4bcc9428eb7b974bf968ae3e ToList<T>(T[] array, Func <T, ST_7d9ca3de97b3b074755ccb195cd9efb0Structure> converter) {
  RL_5009a3db4bcc9428eb7b974bf968ae3e result = new RL_5009a3db4bcc9428eb7b974bf968ae3e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5009a3db4bcc9428eb7b974bf968ae3e FromRestList<T>(RestList<T> restList, Func <T, ST_7d9ca3de97b3b074755ccb195cd9efb0Structure> converter) {
  RL_5009a3db4bcc9428eb7b974bf968ae3e result = new RL_5009a3db4bcc9428eb7b974bf968ae3e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5009a3db4bcc9428eb7b974bf968ae3e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure> NewList() {
return new RL_5009a3db4bcc9428eb7b974bf968ae3e();
}


} // RL_5009a3db4bcc9428eb7b974bf968ae3e
}

