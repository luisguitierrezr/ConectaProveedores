namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ItemEM (7PkN6zfDG0Wll3zaqGctIA)
///  <code>ST_6a8665543a0f720f26db84a82f35885fStructure</code> that represents <code>ItemEM</code
/// > <p>Description: ItemEM</p>
/// </summary>
// Name: ItemEM
public partial struct ST_6a8665543a0f720f26db84a82f35885fStructure : ITypedRecord<ST_6a8665543a0f720f26db84a82f35885fStructure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*qj66K+28gEiQKz+3M_NCdg");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*qM7KK8U6W0m_pD6irKGuOg");
internal static readonly GlobalObjectKey IdCANTIDAD_ENTRADA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*qOD_6dnP+0uQn303ZEv3Tg");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*jXpdc57Tl0OfSV18ehwFWA");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*94T7Ij+oY0OqKr1jOSYjxw");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*H3cDqWqUek66WEcjnBEReg");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public string ssCANTIDAD_ENTRADA;

public string ssCENTRO;

public string ssALMACEN;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_6a8665543a0f720f26db84a82f35885fStructure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "";
ssMATERIAL = "";
ssCANTIDAD_ENTRADA = "";
ssCENTRO = "";
ssALMACEN = "";
ssTEXTO_POSICION = "";
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
ssPOSICION_PEDIDO = r.ReadText(index++, "ItemEM.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "ItemEM.MATERIAL", "");
ssCANTIDAD_ENTRADA = r.ReadText(index++, "ItemEM.CANTIDAD_ENTRADA", "");
ssCENTRO = r.ReadText(index++, "ItemEM.CENTRO", "");
ssALMACEN = r.ReadText(index++, "ItemEM.ALMACEN", "");
ssTEXTO_POSICION = r.ReadText(index++, "ItemEM.TEXTO_POSICION", "");
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
public void ReadIM(ST_6a8665543a0f720f26db84a82f35885fStructure r) {
this = r;
}


public static bool operator == (ST_6a8665543a0f720f26db84a82f35885fStructure a, ST_6a8665543a0f720f26db84a82f35885fStructure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_ENTRADA != b.ssCANTIDAD_ENTRADA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_6a8665543a0f720f26db84a82f35885fStructure a, ST_6a8665543a0f720f26db84a82f35885fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6a8665543a0f720f26db84a82f35885fStructure)) return false;
return (this == (ST_6a8665543a0f720f26db84a82f35885fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_ENTRADA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6a8665543a0f720f26db84a82f35885fStructure Duplicate() {
ST_6a8665543a0f720f26db84a82f35885fStructure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_ENTRADA = this.ssCANTIDAD_ENTRADA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
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
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "cantidad_entrada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_ENTRADA")) variable.Value = ssCANTIDAD_ENTRADA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
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
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCANTIDAD_ENTRADA) {
return ssCANTIDAD_ENTRADA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCANTIDAD_ENTRADA.Key.AsGuid) {
return ssCANTIDAD_ENTRADA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (string) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_ENTRADA = (string) other.AttributeGet(IdCANTIDAD_ENTRADA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_6a8665543a0f720f26db84a82f35885fStructure
/// <summary>
/// RecordList type <code>ItemEMList</code> that represents a record list of <code>ItemEM</code>
/// </summary>
public partial class RL_e2d9cd11480e1409ddda73914c4a2843 : GenericRecordList<ST_6a8665543a0f720f26db84a82f35885fStructure>, IEnumerable, IEnumerator {

protected override ST_6a8665543a0f720f26db84a82f35885fStructure GetElementDefaultValue() {
return new ST_6a8665543a0f720f26db84a82f35885fStructure();
}

public T[] ToArray<T>(Func<ST_6a8665543a0f720f26db84a82f35885fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2d9cd11480e1409ddda73914c4a2843 recordList, Func<ST_6a8665543a0f720f26db84a82f35885fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2d9cd11480e1409ddda73914c4a2843(ST_6a8665543a0f720f26db84a82f35885fStructure[] array) {
  RL_e2d9cd11480e1409ddda73914c4a2843 result = new RL_e2d9cd11480e1409ddda73914c4a2843();
result.InnerFromArray(array);
    return result;
}

public static RL_e2d9cd11480e1409ddda73914c4a2843 ToList<T>(T[] array, Func <T, ST_6a8665543a0f720f26db84a82f35885fStructure> converter) {
  RL_e2d9cd11480e1409ddda73914c4a2843 result = new RL_e2d9cd11480e1409ddda73914c4a2843();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2d9cd11480e1409ddda73914c4a2843 FromRestList<T>(RestList<T> restList, Func <T, ST_6a8665543a0f720f26db84a82f35885fStructure> converter) {
  RL_e2d9cd11480e1409ddda73914c4a2843 result = new RL_e2d9cd11480e1409ddda73914c4a2843();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2d9cd11480e1409ddda73914c4a2843() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6a8665543a0f720f26db84a82f35885fStructure> NewList() {
return new RL_e2d9cd11480e1409ddda73914c4a2843();
}


} // RL_e2d9cd11480e1409ddda73914c4a2843
}

